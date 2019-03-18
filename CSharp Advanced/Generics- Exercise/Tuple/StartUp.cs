namespace Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputOne = Console.ReadLine().Split();
            Tuple<string, string> tupleOne = new Tuple<string, string>($"{inputOne[0]} {inputOne[1]}", inputOne[2]);

            string[] inputTwo = Console.ReadLine().Split();
            Tuple<string, int> tupleTwo = new Tuple<string, int>(inputTwo[0], int.Parse(inputTwo[1]));

            string[] inputThree = Console.ReadLine().Split();
            Tuple<int, double> tupleThree = new Tuple<int, double>(int.Parse(inputThree[0]), double.Parse(inputThree[1]));

            Console.WriteLine(tupleOne);
            Console.WriteLine(tupleTwo);
            Console.WriteLine(tupleThree);
        }
    }
}
