namespace GenericSwapMethodInteger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GenericSwapMethodInteger
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            List<Box<int>> listOfBoxes = new List<Box<int>>();

            for (int i = 0; i < lines; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                listOfBoxes.Add(box);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap<int>(listOfBoxes, indexes[0], indexes[1]);

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine(listOfBoxes[i]);
            }
        }

        public static void Swap<T>(List<Box<T>> listOfBoxes, int indexOne, int indexTwo)
        {
            Box<T> firstBox = listOfBoxes[indexOne];
            listOfBoxes[indexOne] = listOfBoxes[indexTwo];
            listOfBoxes[indexTwo] = firstBox;
        }
    }
}
