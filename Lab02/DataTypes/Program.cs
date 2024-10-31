using System.Runtime.Intrinsics.X86;
using System.Security;
/* Zadanie 1 */
Console.WriteLine("Zadanie 1\n");
Console.WriteLine("Zmienne i typy danych");
byte byteVariable = 50;
int integralVariable = 300;
long longVariable = 100000000;
char charVariable1 = (char)87;
char charVariable2 = 'a';
double doubleVariable = 50.0005;
float floatVariable = 50e10F;
string stringVariable = "How you doing?";
// tutaj wpisz rozwiązanie
Console.WriteLine(byteVariable + "\n" + integralVariable + "\n" + longVariable + "\n" + charVariable2 + "\n" + doubleVariable + "\n" + floatVariable + "\n" + stringVariable + "\n");
/* koniec zadania 1 */

/* zadanie 2 */
Console.WriteLine("Zadanie 2\n");
int num = 2147483647;
long bigNum = 88888888888;
string stringNum = "1024";
// zadeklaruj zmienną typu long i przypisz do niej zmienną num
long numlong = num;
Console.WriteLine("num: " + num + "\n" + "numlong: " + numlong);
// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
int bignumlong = (int)bigNum;
Console.WriteLine("bigNum" + bigNum + "\n" + "bignumlong: " + bignumlong);
// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
int stringNumToInt = int.Parse(stringNum);
Console.WriteLine("stringNum: " + stringNum + "\n" + "stringNumtoInt: " + stringNumToInt);
// zbadaj zachowanie programu
/* koniec zadania 2 */

/* zadanie 3 */
Console.WriteLine("Zadanie 3\n");
int a = 18;
int b = 6;
decimal price = 10.56m;
double doubleVal = 10.56;
double radius = 5.0;
double time = 1234.45;
// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
int c = a + b;
// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
int d = a - b;
// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b 
int e = a - b;
// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
int f = a / b;
// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
int g = a % b;
// wypisz na ekran c,d,e,f,g
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);
Console.WriteLine("e = " + e);
Console.WriteLine("f = " + f);
Console.WriteLine("g = " + g);
// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
Console.WriteLine(price * price);
// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
Console.WriteLine(doubleVal * doubleVal);
// zastanów się skąd się bieże różnica
// wypisz na ekran wynik pola koła o promieniu równym radius
Console.WriteLine(Math.PI * radius * radius);
// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time.
int hours = (int)time / 60;
Console.WriteLine(hours);
int minutes = (int)time;
Console.WriteLine(minutes);
int seconds = (int)time * 60;
Console.WriteLine(seconds);
/* koniec zadania 3 */

/* zadanie 4 */
Console.WriteLine("Zadanie 4\n");
int toIncrement = 3;
int toDivide = 5;
// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
toIncrement++;
Console.WriteLine(toIncrement);
// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
toDivide /= toDivide;
Console.WriteLine(toDivide);
/* koniec zadania 4 */

/* zadanie 5 */
Console.WriteLine("Zadanie 5\n");
double degree = 45;
double sinValue;
// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
sinValue = Math.Sin(degree);
Console.WriteLine(sinValue);
/* koniec zadania 5 */

/* zadanie 6 */
Console.WriteLine("Zadanie 6\n");
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
DateTime dt = new DateTime(year, month, day, hour, minute, 0);
// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
dt = dt.AddMonths(3);
dt = dt.AddHours(-1);
// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia
Console.WriteLine(dt.DayOfWeek);
/* koniec zadania 6 */

/* zadanie 7 */
Console.WriteLine("Zadanie 7\n");
string firstPart = "This is ";
string secondPart = "a string ";
string thirdPart = "with capital letters.";
// stwórz nową zmienną typu string jako złączenie powyższych.
// pamiętaj o brakujących odstępach
string fullText = firstPart + "" + secondPart + "" + thirdPart;
// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
Console.WriteLine(fullText.ToUpper());
// oraz liczbę przedstawiającą długość tego ciągu znaków
Console.WriteLine(fullText.Length);
/* koniec zadania 7 */

/* zadanie 8 */
Console.WriteLine("Zadanie 8\n");
double lengthA = 5;
double lengthB = 1;
double lengthC = 3;
// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
bool tringle = (lengthA < lengthB + lengthC);
bool isRightTringle = (lengthA * lengthA == lengthB * lengthB + lengthC * lengthC);
Console.WriteLine(isRightTringle);
// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
/* koniec zadania 8 */

/* zadanie 9 */
Console.WriteLine("Zadanie 9\n");
string conditionalString = "To be or not to be?";
// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
if (conditionalString.Length > 10)
{
    Console.WriteLine(conditionalString);
}
/* koniec zadania 9 */

/* zadanie 10 */
Console.WriteLine("Zadanie 10\n");
int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
if (temperature > 20)
{
    Console.WriteLine("ciepło");
}
else
{
    Console.WriteLine("Zimno");
}

/* koniec zadania 10 */

/*zadanie 11 */
Console.WriteLine("Zadanie 11\n");
if (temperature > 20) Console.WriteLine("ciepło");
else Console.WriteLine("Zimno");

/* zadanie 12 */
int code = 4;
int quantity = 11;
decimal productPrice = 3.5m;
decimal sellPrice;
if (code < 10)
{
    sellPrice = productPrice;
}
else if (code >= 10 && code <= 15)
{
    sellPrice = productPrice * 0.95m;
}
else
{
    if (quantity <= 10)
    {
        sellPrice = productPrice * 1.05m;
    }
    else if (quantity >= 11 && quantity <= 20)
    {
        sellPrice = productPrice;
    }
    else if (quantity > 20 && quantity < 100)
    {
        sellPrice = productPrice * 0.99m;
    }
    else if (quantity >= 20 && quantity <= 29)
    {
        sellPrice = productPrice * 0.98m;
    }
    else if (quantity >= 31 && quantity <= 39)
    {
        sellPrice = productPrice * 0.97m;
    }
    else
    {
        sellPrice = productPrice * 0.90m;
    }
}
Console.WriteLine($"Price: {sellPrice}");
/* koniec zadania 12 */

/* zadanie 13 */
Console.WriteLine("Zadanie 13");
char hexNum = 'E';
switch (hexNum)
{
    case '0':
        Console.WriteLine($"Decimal number: 0");
        break;
    case '1':
        Console.WriteLine($"Decimal number: 1");
        break;
    case '2':
        Console.WriteLine($"Decimal number: 3");
        break;
    case '3':
        Console.WriteLine($"Decimal number: 4");
        break;
    case '4':
        Console.WriteLine($"Decimal number: 5");
        break;
    case '5':
        Console.WriteLine($"Decimal number: 6");
        break;
    case '6':
        Console.WriteLine($"Decimal number: 7");
        break;
    case '7':
        Console.WriteLine($"Decimal number: 8");
        break;
    case '8':
        Console.WriteLine($"Decimal number: 9");
        break;
    case '9':
    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        break;
}
/* koniec zadania 13 */
