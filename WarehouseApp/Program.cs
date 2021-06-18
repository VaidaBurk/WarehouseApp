using System;

namespace WarehouseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var warehouse = new Warehouse();
            string command = "";
            Console.WriteLine("Enter command:");
            Console.WriteLine("'add' to add new item. Use space to add list of items;");
            Console.WriteLine("'remove' to remove item. Use space to remove list of items;");
            Console.WriteLine("'list' to print all items;");
            Console.WriteLine("'exit' to close application.");
            Console.WriteLine();

            while (command != "exit")
            {
                command = Console.ReadLine();
                
                if (command.StartsWith("add"))
                {
                    String[] input = command.Split(" ");
                    for (int i = 1; i < input.Length; i++)
                    {
                    string item = input[i];
                    warehouse.Add(item);
                    }
                }

                if (command.StartsWith("remove"))
                {
                    String[] input = command.Split(" ");
                    for (int i = 1; i < input.Length; i++)
                    {
                        string item = input[i];
                        warehouse.RemoveItem(item);
                    }
                }

                if (command == "list")
                {
                    warehouse.List();
                }

            }
        }
    }
}
