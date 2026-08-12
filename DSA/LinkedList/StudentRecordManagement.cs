namespace Student
{

    public class Student
    {
        public Node head = null;
        public void RemoveByRollNumber(int rollNumber)
        {
            Node curr = head;
            Node prev = null;
            if (curr != null && curr.RollNo == rollNumber)
            {
                head = curr.next;
                return;
            }
            while (curr != null && curr.RollNo != rollNumber)
            {
                prev = curr;
                curr = curr.next;
               
            }
            prev.next = curr.next;
        }
        public void updateGrade(int roll , char grade)
        {
            Node curr = head;
            while(curr !=null )
            {
                curr = curr.next;
                if(curr.RollNo == roll)
                {
                    curr.Grade = grade;
                    Console.WriteLine("Grade changes successfully");
                    Console.WriteLine(curr.RollNo+" "+ curr.Grade);
                    return;
                }
            }
        }
        public void AddElement(int r, string n, char g, int age)
        {

            Node newNode = new Node(r, n, g, age);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;

            }
            curr.next = newNode;
        }
        public void AddAtBeginning(int roll , string name , char grade , int age)
        {
            Node newNode = new Node(roll , name , grade , age);
            if(head == null)
            {
                head = newNode; return;
            }
            else
            {
                newNode.next = head;
                head= newNode;
               
            }
        }
        public void findByRollNumber(int roll)
        {
            Node curr = head;
            while (curr != null)
            {
                
                if(curr.RollNo == roll)
                {
                    Console.WriteLine("Student with rollNum is found");
                    Console.WriteLine("Roll no is " + curr.RollNo);
                    Console.WriteLine("Name is " + curr.Name);
                    Console.WriteLine("Grade is " + curr.Grade);
                    Console.WriteLine("Age is " + curr.Age);
                    return;
                }
                
                curr = curr.next;
            }
        }
        public void AddAtSpecificPosition(int roll , string name , char grade , int age , int pos)
        {
            Node newNode = new Node(roll , name , grade , age );

            if (pos == 1)
            {
                AddAtBeginning(roll , name , grade , age);
            }
            Node curr = head;
            int count = 1;
            while (curr != null  && count < pos-1)
            {
              
                curr = curr.next;

                count++;
            }
            newNode.next = curr.next;
            curr.next= newNode;



        }
        public void AddAtLast(int roll, string name, char grade, int age)
        {
            Node newNode = new Node(roll, name, grade, age);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
            newNode.next = null;
        }
        public void display()
        {
            Node curr = head;
            while (curr != null)
            {
              
                Console.WriteLine(curr.RollNo + " " + curr.Name + " " + curr.Grade + " " + curr.Age);
                curr = curr.next;
            }
        }
    }
        public class Node
        {
            public int RollNo;
            public string Name;
            public char Grade;
            public int Age;

            public Node next;
            public Node(int rollNo, string name, char grade, int age)
            {
                RollNo = rollNo;
                Name = name;
                Grade = grade;
                Age = age;
            }
        }

    }
