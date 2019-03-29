namespace LinkedList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            LinkedList list = new LinkedList();

            list.AddFirst(1);
            Console.WriteLine($"Result: {list.Head.Value} (State: {list.Head.Value == 1} //Expected: 1)");
            Console.WriteLine($"Result: {list.Tail.Value} (State: {list.Tail.Value == 1} //Expected: 1)");

            list.AddLast(2);
            Console.WriteLine($"Result: {list.Head.Value} (State: {list.Head.Value == 1} //Expected: 1)");
            Console.WriteLine($"Result: {list.Head.Previous} (State: {list.Head.Previous == null} //Expected: null)");
            Console.WriteLine($"Result: {list.Head.Next.Value} (State: {list.Head.Next.Value == 2} //Expected: 2)");
            Console.WriteLine($"Result: {list.Tail.Value} (State: {list.Tail.Value == 2} //Expected: 2)");
            Console.WriteLine($"Result: {list.Tail.Previous.Value} (State: {list.Tail.Previous.Value == 1} //Expected: 1)");
            Console.WriteLine($"Result: {list.Tail.Next} (State: {list.Tail.Next == null} //Expected: null)");
            Console.WriteLine($"Result: {list.Count} (State: {list.Count == 2} //Expected: 2)");

            list.AddFirst(0);
            list.AddLast(3);

            list.RemoveFirst();
            Console.WriteLine($"Result: {list.Head.Value} (State: {list.Head.Value == 1} //Expected: 1)");
            Console.WriteLine($"Result: {list.Head.Previous} (State: {list.Head.Previous == null} //Expected: null)");
            Console.WriteLine($"Result: {list.Tail.Value} (State: {list.Tail.Value == 3} //Expected: 3)");

            list.RemoveLast();
            Console.WriteLine($"Result: {list.Head.Value} (State: {list.Head.Value == 1} //Expected: 1)");
            Console.WriteLine($"Result: {list.Tail.Value} (State: {list.Tail.Value == 2} //Expected: 2)");
            Console.WriteLine($"Result: {list.Tail.Previous.Value} (State: {list.Tail.Previous.Value == 1} //Expected: 1)");
            Console.WriteLine($"Result: {list.Tail.Next} (State: {list.Tail.Next == null} //Expected: null)");

            int[] array = list.ToArray();
            Console.WriteLine($"Result: {string.Join(", ", array)} (State: {string.Join(", ", array) == "1, 2"} //Expected: 1, 2)");

            list.ForEach(n => n--);
            Console.WriteLine($"Result: {list.Head.Value} (State: {list.Head.Value == 0} //Expected: 0)");
            Console.WriteLine($"Result: {list.Tail.Value} (State: {list.Tail.Value == 1} //Expected: 1)");
        }
    }
}
