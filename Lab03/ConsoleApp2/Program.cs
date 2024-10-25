using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

int n = 10;
do
{
    Console.Write(n);
    n--;
}while (n >= 0);
/* Koniec 1 */

/* zadanie 2 */
string hasło;
Console.Write("\nWpisz hasło: ");
do
{
    hasło = Console.ReadLine();

} while (hasło != "koniec");

/* koniec 2 */

/* zadanie 3 */
int a = 1;
Console.WriteLine("Liczby parzyste: ");
while (a <= 100)
{
    if (a % 2 == 0)
        Console.WriteLine(a);
    a++;    
}
/* koniec 3 */

/* zadanie 4 */
for (int i = 0; i < 16; i++)
    Console.WriteLine($"Square of {i} equals {i*i}");
/* koniec 4 */

/* zadanie 5,6 */
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

Console.WriteLine("Liczby, które nie są podzielne przez 7:");

foreach (int number in numbers)
{
    if (number % 7 == 0)
{
        continue;
    }
    Console.WriteLine(number);
}

/* koniec 5,6*/

/* zadanie 7 */
Console.WriteLine("Zadanie 7");
double[] dArray = new double[20];
for (int i = 0; i < 20; i++)
{
    dArray[i] = Math.Sqrt(i);
    Console.WriteLine("i: " + dArray[i]);
}

/* koniec 7 */

/* zadanie 8 */

Console.WriteLine("Zadanie 8");
int[,] matrix = new int[3, 4];

int value = 1;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = value;
        value++;
    }
}
// Wyświetlenie macierzy po transpozycji
Console.WriteLine("Macierz po transpozycji:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[j, i] + " ");
    }
    Console.WriteLine();
}

/* koniec 8 */

/* zadanie 10 */

Console.WriteLine("Zadanie 10");
void PrintUpperCase(string txt)
    {
        Console.WriteLine(txt.ToUpper());
    }
/* koniec 10 */

/* zadanie 11 */

Console.WriteLine("Zadanie 11");
void CreateAndPrintMatrix(int x, int y)
{
    char[,] matrix = new char[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; i < y; j++)
        {
            matrix[i, j] = '#';
        }
        }
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; i < y; j++)
        {
            Console.WriteLine(matrix[i, j]);
    }
        Console.WriteLine();
}

 /* koniec 11 */

/* Zadanie 12 */
string EvenOrOdd1(int toCheck)
{
    string retStr = "";
    if (toCheck % 2 == 0
    {
        retStr = "Even";
    }
    else
    {
        retStr = "Odd";

    }
    return retStr;
}
}

