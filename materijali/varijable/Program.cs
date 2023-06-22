
//deklaracija varijable
using System.Security.Cryptography.X509Certificates;

int i;

//dodjeljivanje vrijednosti
i = 4;

//korištenje varijable

Console.WriteLine(i);
string nizZnakova = "Edunova";
bool logickaVrijednost = true;
Console.WriteLine(logickaVrijednost);

float decimalniBroj = 3.14f;
double decimalniBrojVeci = 3.14;
decimal db = 3.14m;

Console.WriteLine("decimalni broj: {0}\ndb:{1}", 
    decimalniBroj,db);

Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);

int b = int.MaxValue;
b = b + 1;
Console.WriteLine(b);

//tips
int a, q, w = 4;
bool istina = w == 3;
Console.WriteLine(istina);

while (Console.ReadLine() == "/n") ;

