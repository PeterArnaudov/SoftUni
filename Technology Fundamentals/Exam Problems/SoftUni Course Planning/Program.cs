using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Course_Planning
{
    public class Program
    {
        public static void Main()
        {
            //Programming Fundamentals Exam - 01 July 2018 Part I
            string[] separators = new string[] { ", " };
            List<string> schedule = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(':').ToList();

                string commandType = command[0];

                if (command[0] == "course start") break;

                string lesson = command[1];

                if (commandType == "Add")
                {
                    schedule = AddCommand(schedule, lesson);
                }
                else if (commandType == "Insert")
                {
                    int index = int.Parse(command[2]);
                    schedule = InsertCommand(schedule, lesson, index);
                }
                else if (commandType == "Remove")
                {
                    schedule = RemoveCommand(schedule, lesson);
                }
                else if (commandType == "Swap")
                {
                    string lessonTwo = command[2];
                    schedule = SwapCommand(schedule, lesson, lessonTwo);
                }
                else if (commandType == "Exercise")
                {
                    schedule = ExerciseCommand(schedule, lesson);
                }
            }

            for (int i = 1; i <= schedule.Count(); i++)
            {
                Console.WriteLine($"{i}.{schedule[i - 1]}");
            }
        }

        public static List<string> AddCommand(List<string> lessonsAfterAdd, string lessonToAdd)
        {
            if (!lessonsAfterAdd.Contains(lessonToAdd))
            {
                lessonsAfterAdd.Add(lessonToAdd);
            }

            return lessonsAfterAdd;
        }

        public static List<string> InsertCommand(List<string> lessonsAfterInsert, string lessonToInsert, int atIndex)
        {
            if (!lessonsAfterInsert.Contains(lessonToInsert))
            {
                lessonsAfterInsert.Insert(atIndex, lessonToInsert);
            }

            return lessonsAfterInsert;
        }

        public static List<string> RemoveCommand(List<string> lessonsAfterRemove, string lessonToRemove)
        {
            string exercise = $"{lessonToRemove}-Exercise";

            if (lessonsAfterRemove.Contains(lessonToRemove))
            {
                lessonsAfterRemove.Remove(lessonToRemove);

                if (lessonsAfterRemove.Contains(exercise))
                {
                    lessonsAfterRemove.Remove(exercise);
                }
            }

            return lessonsAfterRemove;
        }

        public static List<string> SwapCommand(List<string> lessonsAfterSwap, string lessonOne, string lessonTwo)
        {
            int indexOne = lessonsAfterSwap.IndexOf(lessonOne);
            int indexTwo = lessonsAfterSwap.IndexOf(lessonTwo);

            string exerciseOne = $"{lessonOne}-Exercise";
            string exerciseTwo = $"{lessonTwo}-Exercise";

            if (lessonsAfterSwap.Contains(lessonOne) && lessonsAfterSwap.Contains(lessonTwo))
            {
                lessonsAfterSwap[indexOne] = lessonTwo;
                lessonsAfterSwap[indexTwo] = lessonOne;

                if (lessonsAfterSwap.Contains(exerciseOne) && lessonsAfterSwap.Contains(exerciseTwo))
                {
                    lessonsAfterSwap[indexOne + 1] = exerciseTwo;
                    lessonsAfterSwap[indexTwo + 1] = exerciseOne;
                }
                else if (lessonsAfterSwap.Contains(exerciseOne))
                {
                    if (indexOne < indexTwo)
                    {
                        lessonsAfterSwap.Insert(indexTwo + 1, exerciseOne);
                        lessonsAfterSwap.RemoveAt(indexOne + 1);
                    }
                    else if (indexOne > indexTwo)
                    {
                        lessonsAfterSwap.Insert(indexTwo + 1, exerciseOne);
                        lessonsAfterSwap.RemoveAt(indexOne + 2);
                    }
                }
                else if (lessonsAfterSwap.Contains(exerciseTwo))
                {
                    if (indexOne < indexTwo)
                    {
                        lessonsAfterSwap.Insert(indexOne + 1, exerciseTwo);
                        lessonsAfterSwap.RemoveAt(indexTwo + 2);
                    }
                    else if (indexOne > indexTwo)
                    {
                        lessonsAfterSwap.Insert(indexOne + 1, exerciseTwo);
                        lessonsAfterSwap.RemoveAt(indexTwo + 1);
                    }
                }
            }

            return lessonsAfterSwap;
        }

        public static List<string> ExerciseCommand(List<string> lessonsAfterExercise, string lesson)
        {
            string exercise = $"{lesson}-Exercise";

            if (lessonsAfterExercise.Contains(lesson))
            {
                if (!lessonsAfterExercise.Contains(exercise))
                {
                    lessonsAfterExercise.Insert(lessonsAfterExercise.IndexOf(lesson) + 1, exercise);
                }
            }
            else
            {
                lessonsAfterExercise.Add(lesson);
                lessonsAfterExercise.Add(exercise);
            }

            return lessonsAfterExercise;
        }
    }
}
