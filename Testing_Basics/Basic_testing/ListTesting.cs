using System;
using System.Collections.Generic;
using System.Text;
using Unit_testing_examples;
namespace TestProject1
{
    internal class ListTesting
    {
        AddingElementInList a;
        [SetUp]
        public void setUp()
        {
            a = new AddingElementInList();
        }
        [Test]
        public void check_if_the_element_is_added_to_list()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            a.AddElements(list, 4);
            List<int> ans = new List<int>() { 1, 2, 3, 4 };
            Assert.That(ans, Is.EqualTo(list));
        }
        [Test]
        public void check_if_the_element_is_removed_from_list()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            a.RemoveElements(list, 2);
            List<int> ans = new List<int>() { 1, 3 };
            Assert.That(ans, Is.EqualTo(list));
        }
        [Test]
        public void chcek_the_size_of_List()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            a.GetSize(list);
            int ans = 3;
            Assert.That(ans, Is.EqualTo(ans));
        }
    }
}

            
