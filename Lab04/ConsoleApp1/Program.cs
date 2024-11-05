using ConsoleApp1;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* zasdanie 1 */
            Console.WriteLine(QuadraticEquation());
            Console.WriteLine(QuadraticEquation(1.0, 2.5, 3.2, 4.999));
            /*koniec zadanie 1*/
            /*zadanie 2*/
            double x = 10;
            double y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");
            /*koniec zadanie 2*/
            /*zadanie 3*/
            Multiply(1.0, 2.0);
            Multiply(1.0, 2.0, 3.0);
            Multiply(1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0);
            /*koniec zadanie 3*/
            /*zadanie 4 */
            PrintDayOfTheWeek(DayOfTheWeek.Monday);
            PrintDayOfTheWeek(DayOfTheWeek.Saturday);
            /*koniec zadanie 4*/
            /*zadanie 5*/
            string itemName = "eggplant";
            DateTime date = DateTime.Now;
            decimal price = 1.99m;
            Unit unit = Unit.item;
            Console.WriteLine($"On {date.Year}, the price of {itemName} was {price} per {unit}.");

            PrintDateTime(DateTime.Now);

            DivideSafe(5, 0);
            /*koniec zadanie 5*/
        }
        /*zadanie 6*/
        static double Divide(double a, double b)
        {
            if (b == 0.0)
                throw new DivideByZeroException("b = 0.0 :(");
            return a / b;
        }

        static double DivideSafe(double a, double b)
        {
            double result;
            try
            {
                result = Divide(a, b);
            }
            catch (DivideByZeroException ex)
            {
                result = 0.0;
            }

            return result;
        }
        /*koniec zadanie 6*/
        static void SetYourNewPassword(string password)
        {
            if (password == "")
                throw new ArgumentException("Empty password");

            bool strongPassword = true;

            // tylko male litery
            if (password == password.ToLower())
                strongPassword = false;

            // tylko wielkie litery
            if (password == password.ToUpper())
                strongPassword = false;

            // cyfry (TRUDNE)
            // np. po kolei każdy znak i sprawdzenie "char.IsAsciiDigit == true"

            // znaki specjalne (BARDZO TRUDNE)
            // np. ASCII table

            if (strongPassword)
                throw new FormatException("Too weak password");
        }
        /*koniec zadanie 6*/
        /*zadanie 4 */
        static void PrintDateTime(DateTime date)
        {
            string customDateString = $"{date.Day}...{date.Month}...{date.Year}...{date.Hour}:{date.Minute}:{date.Second}...{date.DayOfWeek}";
            Console.WriteLine(customDateString);
        }
        /*koniec zadanie 4*/
        /*zadanie 1*/
        static double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
        {
            return a * x * x + b * x + c;
        }
        /*koniec zadanie 1*/
        /*zadanie 2*/
        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        /*koniec zadanie 2*/
        /*zadanie 3*/
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        static double Multiply(params double[] a)
        {
            double result = 1.0;
            foreach (double x in a)
            { result *= x; }
            return result;
        }
        /* koniec zadanie 3*/
        /*zadanie 4*/
        static void PrintDayOfTheWeek(DayOfTheWeek day)
        {
            Console.WriteLine(day);
            Console.WriteLine((int)day);

            // opcja 1
            if ((int)day >= 6)
                Console.WriteLine("WEEKEND!!!");
            else
                Console.WriteLine("workweek :-(");

            // opcja 2
            if (day == DayOfTheWeek.Saturday || day == DayOfTheWeek.Sunday)
                Console.WriteLine("WEEKEND!!!");
            else
                Console.WriteLine("workweek :-(");
        }
        /*koniec zadanie 4*/
        bool CheckTheAge(int age)
        {
            if (age < 0)
                throw new ArgumentOutOfRangeException("Age can not be a negative number!");
            if (age >= 18)
                return true;
            else
                return false;
        }
        enum DayOfTheWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        enum Unit { item, kilogram, gram, dozen };
    }
}
