using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

/* zadanie 1 */

Console.WriteLine("Zadanie 1\n");
int k = 10;
do
{
    Console.Write(k);
    k--;
} while (k >= 0);
Console.WriteLine("\n");

/* Koniec 1 */

/* zadanie 2 */

Console.WriteLine("Zadanie 2");
string hasło;
Console.Write("\nWpisz hasło: ");
do
{
    hasło = Console.ReadLine();

} while (hasło != "koniec");

/* koniec 2 */

/* zadanie 3 */

Console.WriteLine("Zadanie 3\n");
int l = 1;
Console.WriteLine("Liczby parzyste: ");
while (l <= 100)
{
    if (l % 2 == 0)
        Console.WriteLine(l);
    l++;    
}

/* koniec 3 */

/* zadanie 4 */

Console.WriteLine("Zadanie 4");
for (int i = 0; i < 16; i++)
    Console.WriteLine($"Square of {i} equals {i * i}");
    Console.WriteLine("\n");
/* koniec 4 */

/* zadanie 5,6 */
Console.WriteLine("Zadanie 5,6\n");
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

Console.WriteLine("Liczby, które nie są podzielne przez 7:");

for (int i = 0; i < numbers.Count; i++)
{
    if (number % 7 == 0)
    {
        continue;
    }
    Console.WriteLine(number); 
}
Console.WriteLine("\n");

/* koniec 5,6*/

/* zadanie 7 */
Console.WriteLine("Zadanie 7\n");
double[] dArray = new double[20];
for (int i = 0; i < 20; i++)
{
    dArray[i] = Math.Sqrt(i);
    Console.WriteLine("i: " + dArray[i]);
    Console.WriteLine("\n");
}

/* koniec 7 */

/* zadanie 8 */

Console.WriteLine("Zadanie 8\n");
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
Console.WriteLine("Macierz po transpozycji:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[j, i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");

/* koniec 8 */

/* zadanie 10 */

Console.WriteLine("Zadanie 10\n");
void printUpperCase(string txt)
{
    Console.WriteLine(txt.ToUpper());
}
printUpperCase("Tekst do druku\n");

/* koniec 10 */

/* Zadanie 11 */
Console.WriteLine("Zadanie 11\n");
void createAndPrintMatrix(int X, int Y)
{
    char[,] matrix = new char[X, Y];
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            matrix[i, j] = '#';
        }
    }

    // Wyświetlanie macierzy na ekranie
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}
createAndPrintMatrix(10, 10);
Console.WriteLine("\n");

/* koniec 11 */

/* Zadanie 12 */

Console.WriteLine("Zadanie 12");
string EvenOrOdd1(int toCheck)
{
    string retStr = "";
    
    if (toCheck % 2 == 0)
    {
        retStr = "Even";
    }
    else
    {
        retStr = "Odd";

    }
    return retStr;
}
Console.WriteLine(EvenOrOdd1(3));
Console.WriteLine(EvenOrOdd1(4));
Console.WriteLine("\n");


/* koniec 12 */

/* Zadanie 13 */

Console.WriteLine("Zadanie 13\n");

int n = wczytajZKlawiatury("n");
int m = wczytajZKlawiatury("m");

char[,] tabl = wypełnijTabl(n, m);

wyswietlTablNaEkran(tabl);
    static int wczytajZKlawiatury(string namePar)
{
    Console.WriteLine($"Podaj wartość dla {namePar}: ");
    return int.Parse(Console.ReadLine());
}
static char[,] wypełnijTabl(int n, int m)
{
    char[,] tabl = new char[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
            {
                tabl[i, j] = '#';
            }
            else
            {
                tabl[i, j] = ' ';
            }
        }
    }

    return tabl;
}
static void wyswietlTablNaEkran(char[,] tabl)
{
    int n = tabl.GetLength(0);
    int m = tabl.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(tabl[i, j]);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("\n");

/* koniec 13 */

/* Zadanie 14 (domowe) */

Console.WriteLine("Zadanie 14 (domowe)\n");

double a = wpiszLiczbe("Podaj wartość a: ");
double b = wpiszLiczbe("Podaj wartość b: ");
double c = wpiszLiczbe("Podaj wartość c: ");
double[] rozwiazania = rozwiazRownanieKwadratowe(a, b, c);
wyswietlWyniki(rozwiazania);
    static double wpiszLiczbe(string komunikat)
{
    Console.Write(komunikat);
    return double.Parse(Console.ReadLine());
}
static double[] rozwiazRownanieKwadratowe(double a, double b, double c)
{
    double d = b * b - 4 * a * c;

    if (d > 0)
    {
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
        return new double[] { x1, x2 };
    }
    else if (d == 0)
    {
        double x = -b / (2 * a);
        return new double[] { x };
    }
    else
    {
        return new double[0];
    }
}
static void wyswietlWyniki(double[] rozwiazania)
{
    Console.WriteLine("       ax^2 + bx + c = 0          ");
    Console.WriteLine("|       Wyniki równania          |");

    if (rozwiazania.Length == 0)
    {
        Console.WriteLine("| Brak rozwiązań rzeczywistych   |");
    }
    else if (rozwiazania.Length == 1)
    {
        Console.WriteLine($"| x = {rozwiazania[0],20} |");
    }
    else
    {
        Console.WriteLine($"| x1 = {rozwiazania[0],18} |");
        Console.WriteLine($"| x2 = {rozwiazania[1],18} |");
    }
}


