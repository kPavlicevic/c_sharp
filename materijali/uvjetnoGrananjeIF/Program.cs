int i = 0;
bool uvjet = i > 0;

if (uvjet) ; 
{
    Console.WriteLine("Veći od 0");
}

//koristiti ćemo ovu sintaksu

if (i > 0) 
{
    Console.WriteLine("Opet veće od 0");
}

//ako se if odnosi na jednu liniju ne trebaju {}

if (!uvjet)
    Console.WriteLine("Nije veće od 0");
    Console.WriteLine("Ovo isto ne bi trebalo biti veće od 0");

//koristiti ćemo uvijek {}

//opcionalna sintaksa

string grad = "Osijek";

if (grad == "Osijek")
{
    Console.WriteLine("SUPER");
}
else 
{
    Console.WriteLine("OK");
}

int b = 0;

if (grad != "Zagreb")
{
    b = b + 1; //broj b se povećava za 1
}
else if (grad == "Split")
{
    b += 1; //broj b se uvećava za 1
}
else if (grad == "Osijek")
{
    b += 2; //broj b se uvećava za 2
}
else 
{
    b++; //broj b se uvećava za 1
}
Console.WriteLine(+b);

//if možemo ugnijezditi
i = 0; b = 2;
if (i > 0) 
{
    if (b == 2) 
    {
        Console.WriteLine("Oba uvjeta su zadovoljena");
    }
}

//korištenje logičkih operatora

if (i > 0 && b == 2) 
{
    Console.WriteLine("Oba uvjeta su zadovoljena");
}

if (i == 4 || b < 0) 
{
}

int g = 10;

if (g % 2 == 0)
{
    Console.WriteLine("Broj je paran");
}
else 
{ 
    Console.WriteLine("Broj je neparan");
}

//? operator - inline if
//ovaj jedan red je istovjetan linijama 80-86

Console.WriteLine("Broj je " + (g % 2 == 0 ? "" : "ne") + "paran");
