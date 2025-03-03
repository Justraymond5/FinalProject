namespace Final_Project___Library_System;
/// <summary>
/// The base class/ abstract that will be used to make children classes
/// </summary>
public abstract class CheckOut
{
    private string _title;
    private int _year;
    private int _time;
    
    /// <summary>
    /// Will get the information "Title" and set that value to "_title"
    /// </summary>
    /// <exception cref="ArgumentException">This just ensures that the title is not blank</exception>
    public string Title 
    {
        get { return _title; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Title cannot be empty.");
            }
            _title = value;
        }
    }
    
    /// <summary>
    /// Will get the information "Year" and set that value to "_year"
    /// </summary>
    /// <exception cref="ArgumentException">This just ensures that the year is not negative</exception>
    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Year must be a positive number.");
            }
            _year = value;
        }
    }
    /// <summary>
    /// Will get the information "Time" and set that value to "_time"
    /// </summary>
    /// <exception cref="ArgumentException">This just ensures that the time is positive</exception>
    public int Time
    {
        get { return _time; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Year must be a positive number.");
            }
            _time = value;
        }
    }
    // The construtor
    /// <summary>
    /// Initalizes three properites
    /// </summary>
    /// <param name="title">Name of the item being checked out; Cant be empty</param>
    /// <param name="time">How long are they going to cheak them out; Not negative</param>
    /// <param name="year">The year the item came out; Not negative</param>
    public CheckOut(string title, int time, int year)
    {
        Title = title;
        Time = time;
        Year = year;
    }

    public abstract void DisplayInfo();
    
    public bool Matches(string query) => Title.Contains(query, StringComparison.OrdinalIgnoreCase);
}