namespace Final_Project___Library_System;
/// <summary>
/// The base class/ abstract that will be used to make children classes
/// </summary>
public abstract class CheckOut
{
    private string _title;
    private int _year;
    private int _time;
    
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
    public CheckOut(string title, int time, int year)
    {
        Title = title;
        Time = time;
        Year = year;
    }

    public abstract void DisplayInfo();
    
    public bool Matches(string query) => Title.Contains(query, StringComparison.OrdinalIgnoreCase);
}