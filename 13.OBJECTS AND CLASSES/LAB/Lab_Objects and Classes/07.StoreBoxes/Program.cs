
namespace _07.StoreBoxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal BoxPrice { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var itemRegister = new List<Box>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] itemData = input.Split().ToArray();

                string serialNum = itemData[0];
                string item = itemData[1];
                int quantity = int.Parse(itemData[2]);
                decimal itemPrice = decimal.Parse(itemData[3]);

                Box currentBox = new Box();

                currentBox.SerialNumber = serialNum;
                currentBox.Item.Name = item;
                currentBox.Item.Price = itemPrice;
                currentBox.Quantity = quantity;
                currentBox.BoxPrice = itemPrice * quantity;

                itemRegister.Add(currentBox);

            }

            var formatedRegister = itemRegister.OrderByDescending(i => i.BoxPrice);

            foreach (var item in formatedRegister)
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.Quantity}");
                Console.WriteLine($"-- ${item.BoxPrice:f2}");
            }
        }
    }
}
