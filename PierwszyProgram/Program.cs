string wyjscieNazwaDruzyny = "Nazwa drużyny: ";
string wyjscieIloscPunktow = "Ilość punktów: ";
string wyjscieWygralaDrużyna = "Wygrała drużyna: ";

string nazwaDruzynyA = "Drużyna Pierścienia";
int iloscPunktowA = 8;
string nazwaDruzynyB = "Drużyna piłkarska";
int iloscPunktowB = 15;

Console.WriteLine(wyjscieNazwaDruzyny + nazwaDruzynyA);
Console.WriteLine(wyjscieIloscPunktow + iloscPunktowA);
Console.WriteLine(wyjscieNazwaDruzyny + nazwaDruzynyB);
Console.WriteLine(wyjscieIloscPunktow + iloscPunktowB);

// Console.WriteLine(iloscPunktowA + iloscPunktowB);
// Console.WriteLine("iloscPunktowA" + iloscPunktowB);

if (iloscPunktowA > iloscPunktowB) {
    Console.WriteLine(wyjscieWygralaDrużyna + nazwaDruzynyA);
}
if (iloscPunktowA < iloscPunktowB) {
    Console.WriteLine(wyjscieWygralaDrużyna + nazwaDruzynyB);
}
if (iloscPunktowA == iloscPunktowB) {
    Console.WriteLine("Mecz zakończył się remisem");
}