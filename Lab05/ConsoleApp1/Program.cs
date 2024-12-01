using ConsoleApp1;

Coords point1 = new Coords(1.0, 1.0);
Console.WriteLine(point1);

Coords point2 = new Coords(1.0, 1.0); ;

if (point1.Equals(point2))
    Console.WriteLine("Equal structs");
else
    Console.WriteLine("Different structs");

point1 = new Coords(1.0, 1.0);
point2 = new Coords(2.0, 2.0);
Console.WriteLine($"Line start=({point1.X},{point1.Y})  Line end=({point2.X},{point2.Y})");

/* Zadanie 1 */
Console.WriteLine(LenghtOfTheLine());

static double LenghtOfTheLine()
{ 
    Coords point1 = new Coords(1.0, 1.0);
    Coords point2 = new Coords(4.0, 1.0);
    Coords point3 = new Coords(4.0, 5.0);
    Coords point4 = new Coords(1.0, 5.0);
    Console.WriteLine($"Początek linii=({point1})  Koniec linii =({point4}).");
    Coords[] points = { point1, point2, point3, point4 };
    double length = GetDistance(points);
    Console.WriteLine($"Długość linii łamanej: {Math.Round(length, 2)}");
    return GetDistance(points);
}

static double GetDistance(Coords[] points)
{
    double distance = 0;
    for (int i = 0; i < points.Length - 1; i++)
    {
        Coords a = points[i];
        Coords b = points[i + 1];
        distance += Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
    }
    return distance;
}

/* Koniec zadanie 1 */

/* zadanie 2 */
static (int Min, int Max) GetMinMax(int[] numbers)
{
    int min = 0, max = 0;
    //Opcja 1
    min = numbers.Min();
    max = numbers.Max();
    //Opcja 2
    foreach (int num in numbers)
    {
        if (num < min) min = num;
        if (num > max) max = num;
    }
    return (min, max);

}
int[] numbers = { 3, 1, 7, 9, -2, 5, 8 };
var result = GetMinMax(numbers);

Console.WriteLine($"Min: {result.Min}, Max: {result.Max}");
Console.WriteLine("");
/* koniec zadanie 2 */

/* Zadanie 3 */
Person person1 = new Person("John", "Doe", new DateTime(2000, 01, 01), "v525252525@microsoft.edu.pl");
person1.FirstName = "John";
person1.LastName = "Doe";
person1.BirthDate = new DateTime(2000, 01, 01);
person1.EmailAddress = "v525252525@microsoft.edu.pl";
Console.WriteLine($"Person number one = {person1.FirstName} {person1.LastName}. Age: {person1.GetAge()} years old. Email: {person1.EmailAddress} .");
Person person2 = new Person("Viktor", "Butenko", new DateTime(2007, 01, 08), "viktor.butenko@gmail.com");
if (person1.IsAdult())
{
    Console.WriteLine(" Person one is already an adult ");
}
else
{
    Console.WriteLine(" Person one  is just a child!");
}
person2.FirstName = "Viktor";
person2.LastName = "Butenko";
person2.BirthDate = new DateTime(2007, 01, 08);
person2.EmailAddress = "viktor.butenko@gmail.com";
Console.WriteLine($"Person number two = {person2.FirstName} {person2.LastName}. Age: {person2.GetAge()} years old. Email: {person2.EmailAddress} .");
if (person2.IsAdult())
{
    Console.WriteLine(" Person two is already an adult.");
}
else
{
    Console.WriteLine(" Person two is just a child!");
}
/* koniec zadanie 3 */
