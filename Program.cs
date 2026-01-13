using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> todoList = new List<string>();

        Console.WriteLine("Welcome to the mini shell! See /help for commands");

        while (true)
        {
            string command = Console.ReadLine().Trim();

            if (command == "/read")
            {
                for (int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine(todoList[i]);
                }
            }
            else if (command == "/add")
            {
                Console.WriteLine("What should I add?");
                string itemToAdd = Console.ReadLine();
                todoList.Add(itemToAdd);
                Console.WriteLine("Added to the list");
            }
            else if (command == "/delete")
            {
                Console.WriteLine("What should be deleted?");
                string itemToDelete = Console.ReadLine();
                todoList.Remove(itemToDelete);
                Console.WriteLine($"{itemToDelete} deleted");
            }
            else if (command == "/settings")
            {
                Console.WriteLine("These are the settings. You can customize everything here.");
                Console.WriteLine("Settings:");
                Console.WriteLine("/color: Changes the background color.");
                Console.WriteLine("/title: Changes the window title");
                Console.WriteLine("/exitsettings: Exit the settings menu");
                Console.WriteLine("Please enter a command.");

                while (true)
                {
                    string settingsCommand = Console.ReadLine().Trim();

                    if (settingsCommand == "/color")
                    {
                        Console.WriteLine("There are five colors: b = Blue, r = Red, g = Green, y = Yellow, d = Default");
                        Console.WriteLine("There are also dark colors: db = Dark Blue, dg = Dark Green, dr = Dark Red, dy = Dark Yellow");

                        string colorInput = Console.ReadLine().Trim();

                        if (colorInput == "b")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                        }
                        else if (colorInput == "r")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                        }
                        else if (colorInput == "g")
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                        }
                        else if (colorInput == "y")
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                        }
                        else if (colorInput == "db")
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                        }
                        else if (colorInput == "dr")
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                        }
                        else if (colorInput == "dg")
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Clear();
                        }
                        else if (colorInput == "dy")
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Clear();
                        }
                        else if (colorInput == "d")
                        {
                            Console.ResetColor();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("This color is not in the list");
                        }
                    }
                    else if (settingsCommand == "/title")
                    {
                        Console.WriteLine("What should the window title be?");
                        string titleInput = Console.ReadLine();
                        Console.Title = titleInput;
                    }
                    else if (settingsCommand == "/exitsettings")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Unknown settings command");
                    }

                    Console.WriteLine("These are the settings. You can customize everything here.");
                    Console.WriteLine("Settings:");
                    Console.WriteLine("/color: Changes the background color.");
                    Console.WriteLine("/title: Changes the window title");
                    Console.WriteLine("/exitsettings: Exit the settings menu");
                    Console.WriteLine("Please enter a command.");
                }
            }
            else if (command == "/help")
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("/help: Displays all available commands.");
                Console.WriteLine("/add, /delete, /read: Add, delete or display all items");
                Console.WriteLine("/settings: Shows the settings.");
                Console.WriteLine("/clear: Clears the console window");
                Console.WriteLine("/exit: Exits the program.");
            }
            else if (command == "/clear")
            {
                Console.Clear();
            }
            else if (command == "/exit")
            {
                Console.WriteLine("Are you sure you want to exit? (y/n)");
                string exitConfirm = Console.ReadLine().Trim();

                if (exitConfirm == "y")
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Unknown command");
            }
        }
    }
}
