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
        
        while (true)
        {
            MainMenu();
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

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
            else if (choice == 3)
            {
                Console.WriteLine("\nItems in the library:");
                foreach (var item in libraryItems)
                {
                    item.DisplayInfo();
                }
            }
            
        }
    }
}
