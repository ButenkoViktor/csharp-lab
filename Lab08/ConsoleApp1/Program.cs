using ConsoleApp1;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Security;
public class Program
{
    static List<Book> books = new List<Book>();
    static void Main(string[] args)
    {
        Console.WriteLine("Zadanie 1");
        var letter = new Letter("Secret content of the letter.");
        var email = new Email("Email content here.");
        var sms = new SMS("This is an SMS.");


        var letterMessenger = new Messenger<Letter>(letter);
        letterMessenger.Send();

        var emailMessenger = new Messenger<Email>(email);
        emailMessenger.Send();

        var smsMessenger = new Messenger<SMS>(sms);
        smsMessenger.Send();
        Console.WriteLine("\n");
        Console.WriteLine("Zadanie 2");
        IEnumerable<string> stringLetter = new string[] { "Hello my name Viktor", "Wesołych Świąt Bożego Narodzenia", "Happy New year" };
        Console.WriteLine("Letter: ");
        foreach (var item in stringLetter)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n");
        Console.WriteLine("Zadanie 3");
        ICollection<string> stringSMS = new List<string> { "Hi, Yaroslav", "How are you?", "Proszę kup banany" };

        Console.WriteLine("<<<Count>>>");
        int count = stringSMS.Count;
        Console.WriteLine($"Count of SMS: {count}\n");

        Console.WriteLine("<<<IsReadOnly>>>");
        Console.WriteLine($"Is the collection read-only? ---> {stringSMS.IsReadOnly}\n");

        Console.WriteLine("<<<Add>>>>");
        stringSMS.Add("HI,Viktor)");
        Console.Write("After adding element: ");
        foreach (var item in stringSMS)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n");

        Console.WriteLine("<<<Contains>>>");
        bool containsHi = stringSMS.Contains("Hi");
        Console.WriteLine($"Contains 'Hi': {containsHi} \n");

        Console.WriteLine("<<<CopyTo>>>");
        string[] targetArray = new string[6];
        stringSMS.CopyTo(targetArray, 2);
        Console.WriteLine("Element in targetArray after CopyTo: ");
        foreach (var item in targetArray)
        {
            Console.WriteLine(item ?? "(null)");
        }
        Console.WriteLine("\n");

        Console.WriteLine("<<<Remove>>>");
        stringSMS.Remove("How are you?");
        Console.WriteLine("After removing 'How are you?': ");
        foreach (var item in stringSMS)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n");

        Console.WriteLine("<<<Clear>>>");
        stringSMS.Clear();
        Console.WriteLine("After calling clear: ");
        foreach (var item in stringSMS)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Count of elements after calling clear: {stringSMS.Count}\n");

        Console.WriteLine("Zadanie 4");
        string wybór = "";
        do
        {
            Console.WriteLine("1. Dodaj książkę");
            Console.WriteLine("2. Wyświetl wszystkie książki");
            Console.WriteLine("3. Wyszukaj książki");
            Console.WriteLine("Q. Koniec");

            wybór = Console.ReadLine();
            switch (wybór)
            {
                case "1":
                    dodaj_książkę();
                    break;
                case "2":
                    wyświetl_książki();
                    break;
                case "3":
                    wyszukaj_książki();
                    break;
                case "Q":
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór!");
                    Console.ReadLine();
                    break;
            }
        } while (wybór != "Q");
    }

    static void dodaj_książkę()
    {
        Console.Clear();
        Console.WriteLine("Wprowadź tytuł książki:");
        string bookTitle = Console.ReadLine();

        Console.WriteLine("Wpisz autora:");
        string bookAuthor = Console.ReadLine();

        Console.WriteLine("Wprowadź rok:");
        int bookYear = Convert.ToInt32(Console.ReadLine());

        books.Add(new Book { Title = bookTitle, Author = bookAuthor, Year = bookYear });
        Console.WriteLine("Książka dodana!");
        Console.ReadLine();
    }

    static void wyświetl_książki()
    {
        Console.Clear();
        Console.WriteLine("Według czego chcesz sortować?");
        Console.WriteLine("1. Title");
        Console.WriteLine("2. Author");
        Console.WriteLine("3. Year");
        string sortBy = Console.ReadLine();
        IEnumerable<Book> sortedBooks = books;

        switch (sortBy)
        {
            case "1":
                sortedBooks = books.OrderBy(v => v.Title);
                break;
            case "2":
                sortedBooks = books.OrderBy(v => v.Author);
                break;
            case "3":
                sortedBooks = books.OrderBy(v => v.Year);
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór!");
                Console.ReadLine();
                return;
        }

        Console.Clear();
        Console.WriteLine("Lista posortowanych książek:");
        foreach (var book in sortedBooks)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }

    static void wyszukaj_książki()
    {
        Console.Clear();
        Console.WriteLine("Według czego chcesz wyszukiwać?");
        Console.WriteLine("1. Title");
        Console.WriteLine("2. Author");
        Console.WriteLine("3. Year");
        string searchBy = Console.ReadLine();
        Console.WriteLine("Wprowadź termin wyszukiwania:");
        string searchTerm = Console.ReadLine();

        IEnumerable<Book> searchedBooks = searchBy switch
        {
            "1" => books.Where(v => v.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)),
            "2" => books.Where(v => v.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)),
            "3" => books.Where(v => v.Year.ToString().Contains(searchTerm)),
            _ => Enumerable.Empty<Book>(),
        };

        Console.Clear();
        if (searchedBooks.Any())
        {
            Console.WriteLine("Lista pasujących książek:");
            foreach (var book in searchedBooks)
            {
                Console.WriteLine(book);
            }
        }
        else
        {
            Console.WriteLine("Nie znaleziono pasujących książek!");
        }
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }
}