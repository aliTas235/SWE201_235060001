// Book.cs
using System;

public class Book
{
    // Private member variables (en az iki)
    private string _title;
    private string _author;
    private int _year; // yayın yılı

    // Public properties
    public string Title
    {
        get { return _title; }
        set { _title = value ?? "Unknown Title"; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value ?? "Unknown Author"; }
    }

    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 0) Console.WriteLine("Year cannot be negative");
            else
            _year = value;
        }
    }

    // Auto-property örneği (opsiyonel, öğretmen iki auto-property kabul ediyordu)
    public string Genre { get; set; }

    // (parametresiz) constructor
    public Book()
    {
        Title = "No Title";
        Author = "No Author";
        Year = 0;
        Genre = "Unknown";
    }

    // Parameterized constructor
    public Book(string title, string author, int year, string genre = "Unknown")
    {
        Title = title;
        Author = author;
        Year = year;
        Genre = genre;
    }

    // Member function: yılı güncelle
    public void UpdateYear(int newYear)
    {
        if (newYear < 0) Console.WriteLine("Year cannot be negative");
        else
        Year = newYear;
    }

    // ToString override
    public override string ToString()
    {
        return "Title: "+Title + " by: " +Author+ "("+ Year +")" +" Genre: "+Genre;
    }
}
