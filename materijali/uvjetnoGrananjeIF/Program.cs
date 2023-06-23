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

