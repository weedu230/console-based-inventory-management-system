using System;

internal class Task2
{
    static void Main()
    {
        string[] inventory = new string[100];
        int count = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Inventory Menu ---");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Display Items");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Add
                    Console.Write("Enter item name: ");
                    inventory[count++] = Console.ReadLine();
                    Console.WriteLine("Item added!");
                    break;

                case 2: // Remove
                    Console.Write("Enter item to remove: ");
                    string remove = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < count; i++)
                    {
                        if (inventory[i] == remove)
                        {
                            for (int j = i; j < count - 1; j++)
                                inventory[j] = inventory[j + 1];
                            count--;
                            found = true;
                            Console.WriteLine("Item removed!");
                            break;
                        }
                    }
                    if (!found) Console.WriteLine("Item not found!");
                    break;

                case 3: // Search
                    Console.Write("Enter item to search: ");
                    string search = Console.ReadLine();
                    bool exists = false;
                    for (int i = 0; i < count; i++)
                        if (inventory[i] == search) exists = true;
                    Console.WriteLine(exists ? "Found!" : "Not found!");
                    break;

                case 4: // Display
                    Console.WriteLine("Inventory items:");
                    for (int i = 0; i < count; i++)
                        Console.WriteLine($"{i + 1}. {inventory[i]}");
                    break;

                case 5: // Exit
                    running = false;
                    Console.WriteLine("Exiting...");
                    break;
            }
        }
    }
}
