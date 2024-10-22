/* zadanie 1 */
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
foreach (int element in numbers)
{
    if (element % 7 == 0)
    Console.WriteLine("Elementy które są podzielne przez 7: " + element); 
    break;
}

/* koniec 5,6*/

/* zadanie 7 */
double[] dArray = new double[20];
for (int i = 0; i < 20; i++)
{
    dArray[i] = Math.Sqrt(i);
    Console.WriteLine("i: " + dArray[i]);
}
/* koniec 7 */

/* zadanie 8 */
 int [,] m = new int[3, 4];
for (int column = 0; column < 3; column++)
{
    for (int row = 0; row < 4; row++)
    {
        m[column, row] = column + row;
    }
}
int[,] t = new int [4, 3];;
for (int column = 0; column < 3; column++)
{
    for (int row = 0, row < 4; row++)
    {
        t[row, column] = m[column, row];
    }
}
/* koniec 8 */

/* zadanie 10 */
void PrintUpperCase(string txt)
    {
        Console.WriteLine(txt.ToUpper());
    }
/* koniec 10 */

/* zadanie 11 */
void CreateMatrix(int x, int y)
{
    char[,] matrix = new char[x, y];
    for(int i =0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            matrix[x, y] = '#';

        }
    }
}
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
string EvenOrOdd3(int toChek)
{
    return toCheck % 2 == 0 ? "Even" : "Odd";
}

