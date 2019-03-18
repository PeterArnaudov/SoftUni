namespace ListyIterator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string command = string.Empty;
            ListyIterator<string> listyIterator = null;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandTokens = command.Split();

                if (commandTokens[0] == "Create")
                {
                    listyIterator = new ListyIterator<string>(commandTokens.Skip(1).ToArray());
                }
                else if (commandTokens[0] ==  "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (commandTokens[0] == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);                        
                    }
                }
                else if (commandTokens[0] == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
            }
        }
    }
}
