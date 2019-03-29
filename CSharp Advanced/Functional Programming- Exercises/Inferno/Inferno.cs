namespace Inferno
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Inferno
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<KeyValuePair<string, int>> filters = new Queue<KeyValuePair<string, int>>();

            Func<string, int, int, List<int>, bool> filter = (type, parameter, num, nums) =>
            {
                bool valid = false;
                int index = nums.IndexOf(num);

                if (type == "Sum Left")
                {
                    if (index == 0)
                    {
                        if (nums[index] == parameter)
                        {
                            valid = true;
                        }
                    }
                    else
                    {
                        if (nums[index] + nums[index - 1] == parameter)
                        {
                            valid = true;
                        }
                    }
                }
                else if (type == "Sum Right")
                {
                    if (index == nums.Count - 1)
                    {
                        if (nums[index] == parameter)
                        {
                            valid = true;
                        }
                    }
                    else
                    {
                        if (nums[index] + nums[index + 1] == parameter)
                        {
                            valid = true;
                        }
                    }
                }
                else if (type == "Sum Left Right")
                {
                    if (nums.Count == 1)
                    {
                        if (nums[index] == parameter)
                        {
                            valid = true;
                        }
                    }
                    else if (index == 0)
                    {
                        if (nums[index] + nums[index + 1] == parameter)
                        {
                            valid = true;
                        }
                    }
                    else if (index == nums.Count - 1)
                    {
                        if (nums[index] + nums[index - 1] == parameter)
                        {
                            valid = true;
                        }
                    }
                    else
                    {
                        if (nums[index - 1] + nums[index] + nums[index + 1] == parameter)
                        {
                            valid = true;
                        }
                    }
                }

                return valid;
            };

            string command = Console.ReadLine();

            while (true)
            {
                if (command.Contains("Exclude"))
                {
                    string[] commandArray = command.Split(';');

                    filters.Enqueue(new KeyValuePair<string, int>(commandArray[1], int.Parse(commandArray[2])));
                }
                else if (command.Contains("Reverse"))
                {
                    if (filters.Count > 0)
                    {
                        filters.Dequeue();
                    }
                }
                else if (command == "Forge")
                {
                    List<int> toExclude = new List<int>();

                    while (filters.Count != 0)
                    {
                        foreach (var number in numbers)
                        {
                            if (filter(filters.Peek().Key, filters.Peek().Value, number, numbers))
                            {
                                toExclude.Add(number);
                            }
                        }

                        filters.Dequeue();
                    }

                    foreach (var number in toExclude)
                    {
                        numbers.Remove(number);
                    }

                    Console.WriteLine(string.Join(" ", numbers));
                    return;
                }

                command = Console.ReadLine();
            }
        }
    }
}
