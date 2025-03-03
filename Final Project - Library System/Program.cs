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

            
        }
    }
}
