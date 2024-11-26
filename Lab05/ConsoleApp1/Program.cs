using ConsoleApp1;

Coords point1 = new Coords(1.0, 1.0);
Console.WriteLine(point1);

Coords point2 = new Coords(1.0, 1.0); ;

if (point1.Equals(point2))
    Console.WriteLine("Equal structs");
else
    Console.WriteLine("Different structs");
/*zadanie 1 */
Console.WriteLine(LenghtOfTheLine());

static double LenghtOfTheLine()
{
    Coords point1 = new Coords(1.0, 1.0);
    Coords point2 = new Coords(1.0, 1.0);
    Coords point3 = new Coords(2.0, 5.0);
    Coords point4 = new Coords(3.0, 2.0);
    Console.WriteLine($"Line start=({point1}) Line end =({point2}).");
    Coords[] points = { point1, point2, point3, point4 };
    Console.WriteLine(GetDistance(points));
    Coords[] point = { point1, point2, point3, point4 };
    return GetDistance(points);

    static double GetDistance(Coords[] coords)
    {
        double distance = 0;
        for (int i = 0; i < coords.Length - 1; i++)
        {
            Coords a = coords[i];
            Coords b = coords[i + 1];
            distance += Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
        }
        return distance;
    }
}

/* koniec 1 */

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