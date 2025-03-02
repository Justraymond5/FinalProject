namespace Final_Project___Library_System;
/// <summary>
/// Added the searchabliy to my libaray items
/// </summary>

// Interface to search
public class SearchList
{
    public interface ISearchList
    {
        bool Matches(string query);
    }
}