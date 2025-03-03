namespace Final_Project___Library_System;
/// <summary>
/// Child class inheriting from the general CheckOut abstract class
/// </summary>
public class Book : CheckOut
{
    public string Author { get; set; }

    public Book(string title, int time, int year, string author) : base(title, time, year)
    {
        Author = author;
    }
    /// <summary>
    /// This will override the class to display everything in the parent class with individual child properties
    /// </summary>
    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}, Check Out Time (in weeks): {Time}, Year Published: {Year}");
    }
}