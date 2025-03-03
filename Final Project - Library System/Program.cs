namespace Final_Project___Library_System;
class Program
{
    static void Main()
    {
        //Ensure that I can add 50+ items
        List<CheckOut> libraryItems = new();
        Console.WriteLine("Welcome to the Library Management System!");
        
        while (true)
        {
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Add a Movie");
            Console.WriteLine("3. Display All Items");
            Console.WriteLine("4. Edit an Item");
            Console.WriteLine("5. Exit");
            Console.Write("\nYour choice: ");

            
        }
    }
}
