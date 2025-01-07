using ConsoleApp1;
using System;
/* Zadanie 2 */
Human Mother = new Human();
Human Father = new Human();
Adult ChildOne = new Adult();
Adult ChildTwo = new Adult();
Adult ChildThree = new Adult();
Mother.Name = "Viktor";
Father.Name = "Alona";
ChildOne.Name = "John";
ChildTwo.Name = "Vlad";
ChildThree.Name = "Oksana";
Console.WriteLine($"Dorośli {Father.Name} i {Mother.Name} mający 3 dzieci:{ChildOne.Name},{ChildTwo.Name} oraz {ChildThree.Name}");
/* Koniec zadania 2 */


/* Zadanie 3 */
Human humanAdult = new Adult();
Console.WriteLine(humanAdult.EatSnack());

Human childAdult = new Child();
Console.WriteLine(childAdult.EatSnack());
/*  koniec zadanie 3 */

/* Zadanie 4 */
Human[] humans = { new Adult(), new Child() };
foreach (var h in humans)
{
    if (h is ISinger singer)
    {
        Console.WriteLine(singer.Sing());
    }
}
/* Koniec zadanie 4 */ 

/* Zadanie 5 */ 
Singers<Child> singers = new Singers<Child>();
singers.Add(new Child("Alica")); singers.Add(new Child("Bob"));
singers.Add(new Child("Charlie"));
singers.Add(new Child("Bob"));
foreach (var singer in singers)
{
    singer.Sing();
}
/* Koniec 4 */

/* Zadanie 5 */
Book bookOne = new Book();    
Book bookTwo = new Book();    
Book bookThree = new Book();
Book bookFour = new Book();

bookOne.Title = "Ulysses";
bookOne.Author = "James Joyce";
bookOne.YearPublished = 1922;

bookTwo.Title = "Lolita";
bookTwo.Author = "Vladimir Nabokov";
bookTwo.YearPublished = 1955;

bookThree.Title = "The Great Gatsby";
bookThree.Author = "F. Scott Fitzgerald";
bookThree.YearPublished = 1925;

bookFour.Title = "In Search of Lost Time";
bookFour.Author = "Marcel Proust";
bookFour.YearPublished = 1913;

List<Book> books = new List<Book> { bookOne, bookTwo, bookThree, bookFour };
var authors = books.Select(b => b.Author).Distinct().OrderBy(a => a).ToList();
Console.WriteLine("Autorzy w kolejności:");
foreach (var author in authors)
{
    Console.WriteLine(author);
}

var favBook = new Book { Title = "1984", Author = "George Orwell", YearPublished = 1949 };
books.Add(favBook);

var Booksolder100 = books.Where(b => DateTime.Now.Year - b.YearPublished > 100).Select(b => b.Title).ToList();
Console.WriteLine("\nKsiążki starsze niż 100 lat:");
foreach (var title in Booksolder100)
{
    Console.WriteLine(title);
}

var OldBook = books.OrderBy(b => b.YearPublished).First();
books.Remove(OldBook);
