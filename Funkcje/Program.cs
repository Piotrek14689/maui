// See https://aka.ms/new-console-template for more information
// dotnet new console -n Funkcje -f net10.0
Console.WriteLine("Hello, World!");

mojaMetoda();
Console.WriteLine($"Wynik dodawania 2 + 3 to {dodaj(2, 3)}");

// uint wiek;
// Console.Write("Podaj swój wiek: ");
// uint.TryParse(Console.ReadLine(), out wiek);

// if (czyPelnoletni(wiek))
// {
//     Console.WriteLine($"Jesteś pełnoletni, twój wiek to {wiek}");
// }
// else
// {
//     Console.WriteLine($"Jesteś niepełnoletni, twój wiek to {wiek}");
// }

string nazwaDruzyny;
Console.Write("Podaj nazwe druzyny: ");
nazwaDruzyny = Console.ReadLine() ?? "";

if(nazwaDruzyny == "")
{
    Console.WriteLine("Brak poprawnych danych");
    return;
}
Console.WriteLine($"Witaj, {nazwaDruzyny}");

int x = 0;

while (x < 10)
{
    x++;
    Console.WriteLine(x);
}

static void mojaMetoda()
{
    Console.WriteLine("Hej");
}

static int dodaj(int a, int b)
{
    return a+b;
}