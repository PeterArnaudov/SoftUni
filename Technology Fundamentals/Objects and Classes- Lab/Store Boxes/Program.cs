using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Boxes
{
    public class Program
    {
        public static void Main()
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] information = input.Split();

                boxes.Add(new Box(information));
            }

            //foreach (var box in boxes.OrderByDescending(x => x.Price))
            //{
            //    Console.WriteLine(box.ToString());
            //} <- можеш да използваш и това закоментираното вместо долното на един ред

            boxes.OrderByDescending(x => x.Price).ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
    }

    public class Item
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }

        public Box(string[] information)
        {
            SerialNumber = information[0];

            Item = new Item()
            {
                ItemName = information[1],
                ItemPrice = double.Parse(information[3])
            };

            ItemQuantity = int.Parse(information[2]);
            Price = Item.ItemPrice * ItemQuantity;
        }

        public override string ToString()
        {
            string output = $"{SerialNumber}{Environment.NewLine}-- {Item.ItemName} - ${Item.ItemPrice:f2}: {ItemQuantity}{Environment.NewLine}-- ${Price:f2}";

            return output;
        }
    }
}
