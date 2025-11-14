// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {

        // 1) Parametresiz constructor
        Book b1 = new Book();
        Console.WriteLine("Default book:");
        Console.WriteLine(b1);
        Console.WriteLine();

        // 2) Parametreli constructor
        Book b2 = new Book("1984", "George Orwell", 1949, "Dystopian");
        Book b3 = new Book("Clean Code", "Robert C. Martin", 2008, "Programming");

        Console.WriteLine(b2);
        Console.WriteLine(b3);
        Console.WriteLine();

        // 3) Property'leri kullanma / değiştirme
        b1.Title = "The Little Prince";
        b1.Author = "Antoine de Saint-Exupéry";
        b1.Year = 1943;
        b1.Genre = "Fable";

        Console.WriteLine("After setting properties on default book:");
        Console.WriteLine(b1);
        Console.WriteLine();

        // 4) Member function kullanımı (yıl güncelle)
        Console.WriteLine("Updating year of 'Clean Code' to 2009...");
        b3.UpdateYear(2009);
        Console.WriteLine(b3);
        Console.WriteLine();

        // 5) Dizi içinde saklama ve yazdırma (Main içinde array kullanımı)
        Book[] library = new Book[3];
        library[0] = b1;
        library[1] = b2;
        library[2] = b3;

        Console.WriteLine("Library contents:");
        foreach (var book in library)
        {
            Console.WriteLine(book);
        }
    }
}
