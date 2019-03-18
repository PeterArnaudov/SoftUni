namespace CustomList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            CustomList list = new CustomList();

            //Adding to the list tests:
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine($"Result: {list[0]} (State: {list[0] == 0} //Expected: 0)");
            Console.WriteLine($"Result: {list[1]} (State: {list[1] == 1} //Expected: 1)");
            Console.WriteLine($"Result: {list[2]} (State: {list[2] == 2} //Expected: 2)");
            Console.WriteLine($"Result: {list[3]} (State: {list[3] == 3} //Expected: 3)");

            //Checking if the list.Count works properly test:
            Console.WriteLine($"Result: {list.Count} (State: {list.Count == 4} //Expected: 4)");

            //Removing an element at an index from the list test:
            list.RemoveAt(2);
            Console.WriteLine($"Result: {list[2]} (State: {list[2] == 3} //Expected: 3)");

            //Inserting an element into the list test:
            list.Insert(2, 2);
            Console.WriteLine($"Result: {list[2]} (State: {list[2] == 2} //Expected: 2)");

            //Checking if an element is contained in the list tests:
            list.Contains(2);
            list.Contains(5);
            Console.WriteLine($"Result: {list.Contains(2)} (State: {list.Contains(2) == true} //Expected: True)");
            Console.WriteLine($"Result: {list.Contains(5)} (State: {list.Contains(5) == false} //Expected: False)");

            //Swaping two elements from the list tests:
            list.Swap(0, 3);
            Console.WriteLine($"Result: {list[0]} (State: {list[0] == 3} //Expected: 3)");
            Console.WriteLine($"Result: {list[3]} (State: {list[3] == 0} //Expected: 0)");
        }
    }
}
