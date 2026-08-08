//1.Smart Warehouse Management System
//o Concepts: Generic Classes, Constraints, Variance
//o Problem Statement: Develop a warehouse system that manages
//different types of items (Electronics, Groceries, Furniture).
//o Hints:
// Create an abstract class WarehouseItem that all items
//extend (Electronics, Groceries, Furniture).
// Implement a generic class Storage&lt; T & gt; where T :
//WarehouseItem to store items safely.
// Implement a method to display all items using List&lt; T & gt;.

using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public abstract class WarehouseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public WarehouseItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
