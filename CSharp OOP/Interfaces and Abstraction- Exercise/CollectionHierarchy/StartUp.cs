namespace CollectionHierarchy
{
    using System;
    using Classes;

    public class StartUp
    {
        public static void Main()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] items = Console.ReadLine().Split();
            int removeOperations = int.Parse(Console.ReadLine());

            foreach (var item in items)
            {
                Console.Write(addCollection.Add(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in items)
            {
                Console.Write(addRemoveCollection.Add(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in items)
            {
                Console.Write(myList.Add(item) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < removeOperations; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < removeOperations; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
