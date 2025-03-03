namespace Final_Project___Library_System;
class Program
{
    /// <summary>
    /// Method for holding the prompt
    /// </summary>
    static void MainMenu()
    {
        Console.WriteLine("\nPlease choose an option:");
        Console.WriteLine("1. Add a Book");
        Console.WriteLine("2. Add a Movie");
        Console.WriteLine("3. Display All Items");
        Console.WriteLine("4. Edit an Item");
        Console.WriteLine("5. Exit");
        Console.Write("\nYour choice: ");
        
    }
    static void Main()
    {
        //Ensure that I can add 50+ items
        List<CheckOut> libraryItems = new();
        Console.WriteLine("Welcome to the Library Management System!");
        // Loop of the main entry point to run the if statements
        while (true)
        {
            MainMenu();
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }
            //Added the book item
            if (choice == 1)
            {
                Console.Write("Enter book title: ");
                string title = Console.ReadLine();
                Console.Write("Enter check-out time (in weeks): ");
                if (!int.TryParse(Console.ReadLine(), out int time)) { Console.WriteLine("Invalid check-out time."); continue; }
                Console.Write("Enter year published: ");
                if (!int.TryParse(Console.ReadLine(), out int year)) { Console.WriteLine("Invalid year."); continue; }
                Console.Write("Enter author: ");
                string author = Console.ReadLine();
                
                libraryItems.Add(new Book(title, time, year, author));
                Console.WriteLine("Book added successfully!");
            }
            //Added the movie item
            else if (choice == 2)
            {
                Console.Write("Enter movie title: ");
                string title = Console.ReadLine();
                Console.Write("Enter check-out time (in weeks): ");
                if (!int.TryParse(Console.ReadLine(), out int time)) { Console.WriteLine("Invalid check-out time."); continue; }
                Console.Write("Enter year released: ");
                if (!int.TryParse(Console.ReadLine(), out int year)) { Console.WriteLine("Invalid year."); continue; }
                Console.Write("Enter director: ");
                string director = Console.ReadLine();
                
                libraryItems.Add(new Movie(title, time, year, director));
                Console.WriteLine("Movie added successfully!");
            }
            //Displays the books and movies items
            else if (choice == 3)
            {
                Console.WriteLine("\nItems Checked Out:");
                foreach (var item in libraryItems)
                {
                    item.DisplayInfo();
                }
            }
            //Searches to edit
            else if (choice == 4)
            {
                Console.Write("Enter title of book or movie you want to edit: ");
                string title = Console.ReadLine();
                //Uses list to find item
                var foundItems = libraryItems.FindAll(i => i.Matches(title));
                
                if (foundItems.Count > 0)
                {
                    foreach (var item in foundItems)
                    {
                        item.DisplayInfo();
                        Console.Write("Would you like to update the check out time? (yes/no): ");
                        string response = Console.ReadLine().ToLower();
                        if (response == "yes")
                        {
                            Console.Write("Enter new check-out time (in weeks): ");
                            if (int.TryParse(Console.ReadLine(), out int newTime) && newTime > 0)
                            {
                                item.Time = newTime;
                                Console.WriteLine("Check-out time updated successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Could not find your item, try again");
                }
            }
            //Ends while loop and program
            else if (choice == 5)
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Enter a number between 1 and 5.");
            }
        }
    }
}
