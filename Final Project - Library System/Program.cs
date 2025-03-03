namespace Final_Project___Library_System;
// Author: Raymond Gonzalez Ramirez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Final project: Library Management System to demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
class Program
{
    /// <summary>
    /// Method for holding the prompt
    /// </summary>
    
    //<Method storing> 
    static void MainMenu()
    {
        Console.WriteLine("\nPlease choose an option:");
        Console.WriteLine("1. Add a Book");
        Console.WriteLine("2. Add a Movie");
        Console.WriteLine("3. Display All Items");
        Console.WriteLine("4. Edit an Item");
        Console.WriteLine("5. Remove an Item");
        Console.WriteLine("6. Exit");
        Console.Write("\nYour choice: ");
        
    }
//method for book promt
    static void AddBook(List<CheckOut> libraryItems)
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();
        
        Console.Write("Enter check-out time (in weeks): ");
        if (!int.TryParse(Console.ReadLine(), out int time)) { Console.WriteLine("Invalid check-out time."); return; }
        
        Console.Write("Enter year published: ");
        if (!int.TryParse(Console.ReadLine(), out int year)) { Console.WriteLine("Invalid year."); return; }
        
        Console.Write("Enter author: ");
        string author = Console.ReadLine();

        libraryItems.Add(new Book(title, time, year, author));
        Console.WriteLine("Book added successfully!");
    }
    //method for Movie promt
    static void AddMovie(List<CheckOut> libraryItems)
    {
        Console.Write("Enter movie title: ");
        string title = Console.ReadLine();
        
        Console.Write("Enter check-out time (in weeks): ");
        if (!int.TryParse(Console.ReadLine(), out int time)) { Console.WriteLine("Invalid check-out time."); return; }
        
        Console.Write("Enter year released: ");
        if (!int.TryParse(Console.ReadLine(), out int year)) { Console.WriteLine("Invalid year."); return; }
        
        Console.Write("Enter director: ");
        string director = Console.ReadLine();
                
        libraryItems.Add(new Movie(title, time, year, director));
        Console.WriteLine("Movie added successfully!");
    }
    // </Method storing> 
    static void Main()
    {
        //Ensure that I can add 50+ items
        // LibaryItems contains both books and Movies
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
                AddBook(libraryItems);
                
            }
            //Added the movie item
            else if (choice == 2)
            {
                
                AddMovie(libraryItems);
                
            }
            //Displays the books and movies items
            else if (choice == 3)
            {
                Console.WriteLine("\nItems Checked Out:");
                if (libraryItems.Any())
                {
                    foreach (var item in libraryItems)
                    {
                        item.DisplayInfo();
                    }
                }
                else
                    {
                        Console.WriteLine("There is nothing that has been checked out");
                        continue;
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
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Could not find your item, try again");
                }
            }
            //Removes items from list
            else if (choice == 5)
            {
                Console.Write("Enter title of the book or movie you want to delete: ");
                string title = Console.ReadLine();
                
                
                var itemToDelete = libraryItems.FirstOrDefault(i => i.Matches(title));

                if (itemToDelete != null)
                {
                    libraryItems.Remove(itemToDelete);
                    Console.WriteLine("Item deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Could not find the item to delete.");
                    continue;
                }
            }
            //Ends while loop and program
            else if (choice == 6)
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Enter a number between 1 and 6.");
                continue;
            }
        }
    }
}
