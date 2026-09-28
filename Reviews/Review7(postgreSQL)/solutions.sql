/*
Problem – Courier & Shipment Tracking
Create a Courier Management system containing customers, branches, shipments, packages, delivery agents and tracking events.

Requirements
Implement:


Normalized schema with suitable datatypes.

PK/FK and CHECK constraints.

Joins to display shipment tracking details.

CTE to calculate branch-wise shipment statistics.

Subquery to find customers having shipment volume above average.

Temporary table for delayed shipments.

View for active shipment tracking.

UDF to calculate shipping cost based on weight and distance.

Stored procedure to create shipment.

Trigger to automatically record a tracking event when shipment status changes.

Cursor to generate delayed-shipment reports.

Indexes on tracking number, customer ID and shipment status.

Demonstrate transaction and locking during shipment status update.

Create shipment and tracking schemas with DCL.
*/

--CREATING SCHEMA
Create schema shipment;

Create schema tracking;
CREATE TABLE shipment.customers (
    customer_id SERIAL PRIMARY KEY,
    name VARCHAR(30),
    phone_no VARCHAR(10),
    email VARCHAR(100) UNIQUE
);
CREATE TABLE shipment.branches(
branch_id SERIAL PRIMARY KEY,
branch_name VARCHAR(20)
);
SELECT * FROM shipment.customers;
Select * from shipment.branches;
CREATE TABLE shipment.delivery_agents (
    agent_id SERIAL PRIMARY KEY,
    agent_name VARCHAR(30),
    phone_no VARCHAR(10),
    email VARCHAR(100) UNIQUE,
    branch_id INT REFERENCES shipment.branches(branch_id)
);
CREATE TABLE shipment.shipments (
    shipment_id SERIAL PRIMARY KEY,
    customer_id INT REFERENCES shipment.customers(customer_id),
    tracking_number VARCHAR(10) UNIQUE NOT NULL,
    source_branch INT REFERENCES shipment.branches(branch_id),
    destination_branch INT REFERENCES shipment.branches(branch_id),
    agent_id INT REFERENCES shipment.delivery_agents(agent_id),
    status VARCHAR(20) CHECK (
        status IN ('CREATED', 'IN_TRANSIT', 'DELIVERED', 'DELAYED', 'EARLY')
    )
);
CREATE TABLE shipment.packages (
    package_id SERIAL PRIMARY KEY,
    shipment_id INT REFERENCES shipment.shipments(shipment_id),
    description VARCHAR(100),
    weight NUMERIC(6,2) CHECK (weight > 0)
);
INSERT INto shipment.customers(name , phone_no , email)Values(
'Vanshika' , '9876543210' , 'vanshika@gmail.com'),
('Vishakha' , '9900887712' , 'vishakha@gmail.com'),
('Urvi' , '9911228833' , 'urvi@gmail.com');
select * from shipment.customers;

CREATE TABLE tracking.events (
    event_id SERIAL PRIMARY KEY,
    shipment_id INT REFERENCES shipment.shipments(shipment_id),
    status VARCHAR(20),
    event_time TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
INSERT INTO shipment.shipments(tracking_number , customer_id , source_branch , destination_branch , agent_id , status )VALUES('SN1' , 1  , 1 , 2 , 1 , 'IN_TRANSIT') , ('SNO12' , '2' , '2' , '3' , '2' , 'DELIVERED'),
('SNO13' , 3 , 3 ,  1 , 3 , 'DELAYED');
INSERT INTO tracking.events(shipment_id , status )Values(4 , 'CREATED'),(5 , 'CREATED') , (6 , 'DELIVERED');
INSERT INTO shipment.branches (branch_name)
VALUES('Delhi Branch'),('Ambala Branch'),('Panipat Branch'),('Rajpura Branch');
Select * from shipment.delivery_agents;
INSERT INTO shipment.packages
(shipment_id, description, weight)
VALUES(4, 'Books', 5.5),(5, 'Clothes', 2.0),(6, 'Electronics', 10.0);
INSERT INTO shipment.delivery_agents
(agent_name, phone_no, email, branch_id)
VALUES
('Ramesh', '9897154556', 'ramesh@gmail.com', 1),
('Vikas', '8877996622', 'vikas@gmail.com', 2),
('Raghav', '7788994455', 'raghav@gmail.com', 3),
('Harry', '8855223366', 'harry@gmail.com', 4);
--Joins to display shipment tracking details.

SELECT s.shipment_id  , s.tracking_number  , c.name , s.status , e.event_time from shipment.shipments s JOIN shipment.customers c on s.customer_id = c.customer_id
join tracking.events e on s.shipment_id = e.shipment_id;

--CTE to calculate branch-wise shipment statistics.
With branch_stats AS (
SELECT source_branch  , COUNT(*) AS total_shipments from shipment.shipments Group by source_branch
)
SELECT * FROM branch_stats;
--Subquery to find customers having shipment volume above average.
Select customer_id , COUNT(*) AS shipment_count from shipment.shipments GROUP BY customer_id 
Having count(*) > (SELECT AVG(cnt) from(select count(*) as cnt from shipment.shipments group by customer_id)x);
--Temporary table for delayed shipments.
CREATE TEMP TABLE delayed_shipments as SELECT * from shipment.shipments where status ='DELAYED';
--View for active shipment tracking.

CREATE view active_shipments as SELECT * FROM shipment.shipments where status != 'DELIVERED';

--UDF to calculate shipping cost based on weight and distance.
CREATE or replace FUNCTION shipment.calculate_cost(
p_weight NUMERIC,
p_dis NUMERIC
)
RETURNS NUMERIC
LANGUAGE PLPGSQL
as $$
begin 
return (p_weight*10)+(p_dis*2);
END;
$$;
SELECT shipment.calculate_cost(5  , 100);
---Stored procedure to create shipment.
CREATE OR REPLACE PROCEDURE shipment.create_shipment(
    p_tracking_number VARCHAR,
    p_customer_id INT,
    p_source INT,
    p_destination INT,
    p_agent_id INT
)
LANGUAGE plpgsql
AS $$
BEGIN
    INSERT INTO shipment.shipments
    (tracking_number, customer_id, source_branch,
     destination_branch, agent_id, status)
    VALUES
    (p_tracking_number, p_customer_id, p_source,
     p_destination, p_agent_id, 'CREATED');
END;
$$;
CALL shipment.create_shipment('TRK006', 1, 1, 3, 1);

--Trigger to automatically record a tracking event when shipment status changes.
CREATE OR REPLACE FUNCTION tracking.status_changed()
RETURNS TRIGGER
LANGUAGE plpgsql
AS $$
BEGIN
    IF OLD.status != NEW.status THEN
        INSERT INTO tracking.events (shipment_id, status)
        VALUES (NEW.shipment_id, NEW.status);
    END IF;

    RETURN NEW;
END;
$$;
CREATE TRIGGER shipment_status_trigger
AFTER UPDATE OF status
ON shipment.shipments
FOR EACH ROW
EXECUTE FUNCTION tracking.status_changed();

UPDATE shipment.shipments
SET status = 'DELIVERED'
WHERE shipment_id = 5;

SELECT * FROM tracking.events;
--Cursor to generate delayed-shipment reports.
DO $$ DECLARE
rec RECORD;
delayed_cursor CURSOR FOR
SELECT tracking_number, customer_id FROM shipment.shipments WHERE status = 'DELAYED';
BEGIN
OPEN delayed_cursor;
LOOP
FETCH delayed_cursor INTO rec;
EXIT WHEN NOT FOUND;
RAISE NOTICE 'Tracking: %, Customer: %', rec.tracking_number, rec.customer_id;
END LOOP;
CLOSE delayed_cursor;
END $$;
--Indexes on tracking number, customer ID and shipment status.

CREATE INDEX idx_tracking_number
ON shipment.shipments(tracking_number);

CREATE INDEX idx_customer_id
ON shipment.shipments(customer_id);

CREATE INDEX idx_status
ON shipment.shipments(status);

--Demonstrate transaction and locking during shipment status update.
BEGIN;

SELECT *
FROM shipment.shipments
WHERE shipment_id = 4
FOR UPDATE;

UPDATE shipment.shipments
SET status = 'DELIVERED'
WHERE shipment_id = 4;

COMMIT;
--DCL 
CREATE USER courier_user WITH PASSWORD '1234';

GRANT USAGE ON SCHEMA shipment TO courier_user;
GRANT USAGE ON SCHEMA tracking TO courier_user;

GRANT SELECT, INSERT, UPDATE
ON ALL TABLES IN SCHEMA shipment
TO courier_user;

GRANT SELECT, INSERT
ON ALL TABLES IN SCHEMA tracking
TO courier_user;
