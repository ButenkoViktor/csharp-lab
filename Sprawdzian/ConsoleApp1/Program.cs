using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json.Serialization.Metadata;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            // tutaj rozwiązanie zadania 1
            for (int i = b; i >= a; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Kończę zadanie 1");
            }
        }
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            // zaimplementuj poniższą procedurę
            static void PrintTriangle(int n)
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(new string('$', i));
                }
            }
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;
            // tutaj rozwiązanie zadania 3
            if (today.Hour <= 12)
            {
                Console.WriteLine($"Dzień dobry, dzisiaj {today.DayOfWeek}, czyli {today.Day} dzień tygodnia.");
            }
            else
            {
                Console.WriteLine($"Dobry wieczór, dzisiaj {today.DayOfWeek}, czyli {today.Day} tygodnia");
            }
            string finalText = $"Dobry wieczór, dzisiaj {today.DayOfWeek}, czyli {today.Day} tygodnia";
            Console.WriteLine(finalText);

            Console.WriteLine("Kończę zadanie 3");
        }
        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };
            // zadanie numer 4
            // zaimplementuj poniższą funkcję
            static double FindMaxAbsoluteValue(double[] numbers)
            {
                double b = -numbers.Min();
                double a = numbers.Max();
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }
        static void Zadanie_5_6()
        {



        // tutaj rozwiązanie zadań 5 oraz 6
        // można modyfikować, zmieniać kolejność itp.
        loop:
            Console.WriteLine("Rozpoczynam pętlę.");

            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");
            string conv = Console.ReadLine();
            try
            {
                int num = Int32.Parse(conv);
                switch (num)
                {
                    case 1:
                        Zadanie_1(); goto loop; break;
                    case 2:
                        Zadanie_2(); goto loop; break;
                    case 3:
                        Zadanie_3(); goto loop; break;
                    case 4:
                        Zadanie_4(); goto loop; break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego zadania, wybierz ponownie.");
                        goto loop;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie ma takiego zadania, wybierz ponownie.");
                goto loop;
            }
            Console.WriteLine("Konczę pętlę");
        }
    }
}







