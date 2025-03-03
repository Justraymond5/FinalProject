namespace Final_Project___Library_System;
/// <summary>
/// Child class inheriting from the general CheckOut abstract class
/// </summary>
public class Movie : CheckOut
{
    public string Director { get; set; }

    public Movie(string title, int time, int year, string director) : base(title, time, year)
    {
        Director = director;
    }
    /// <summary>
    /// This will override the class to display everything in the parent class with individual child properties
    /// </summary>
    public override void DisplayInfo()
    {
        Console.WriteLine($"Movie: {Title}, Director: {Director}, Check Out Time: {Time} weeks, Year: {Year}");
    }
}