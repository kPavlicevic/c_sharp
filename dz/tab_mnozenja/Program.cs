// See https://aka.ms/new-console-template for more information
// DZ
//		Kreiraj program koji će koristeći for petlje
//		automatizirati ispis tablice množenja u ovom obliku:
//		-------------------------------
//		: : :  TABLICA  MNOZENJA  : : :
//		-------------------------------
//		 * |  1  2  3  4  5  6  7  8  9
//		-------------------------------
//		 1 |  1  2  3  4  5  6  7  8  9
//		 2 |  2  4  6  8 10 12 14 16 18
//		 3 |  3  6  9 12 15 18 21 24 27
//		 4 |  4  8 12 16 20 24 28 32 36
//		 5 |  5 10 15 20 25 30 35 40 45
//		 6 |  6 12 18 24 30 36 42 48 54
//		 7 |  7 14 21 28 35 42 49 56 63
//		 8 |  8 16 24 32 40 48 56 64 72
//		 9 |  9 18 27 36 45 54 63 72 81 
//		-------------------------------
//		:  :  :  :  :  :   :by Tomislav
//		-------------------------------
//		Umjesto "Ime" treba ispisati ime uneseno s
//		konzole i pri tome pripaziti da zadnje slovo
//		imena bude poravnato s desnim rubom tablice.

string razdvojnik = "-------------------------------";
string raz_dvotocka = ":  :  :  :  :  :  :  ";
string zaglavlje = ": : :  TABLICA  MNOZENJA  : : :";
string razmak = "  ";
string umnozak;

//Zaglavlje
//zelimo ga samo jednom zato ide prije petlji
Console.WriteLine(razdvojnik);
Console.WriteLine(zaglavlje);
Console.WriteLine(razdvojnik);


//Tablica
for (int i = 0; i < 10; i++) {
    //samo umjesto 0 zelimo ispisati *
    if (i == 0)
    {
        Console.Write("* |  ");
    }
    //u suprotnom zelimo ispisati umnozenika, odnosno i, odnosno ovime popunjavamo vrijednsoti prvog stupca
    else {
        Console.Write(i);
        Console.Write(" |");
    }
    for (int j = 1; j < 10; j++) {
        //Ako smo u prvom retku onda zelimo ispisati umnozitelja odnosno j
        if (i == 0)
        {
            Console.Write(j);
            Console.Write(razmak[^2..]);
        }
        //u svako drugom slucaju zelimo ispisati umnozak, odnosno vrijednosti tablice mnozenja
        else {
            umnozak = "   " + i * j;
            Console.Write(umnozak[^3..]);
        }
    }
    //Kada samo zavrsili sa retkom, odnosno izvrsavanjem j petelj, zelimo preci u novi redak,
    //prije nego inkrementiramo i
    Console.WriteLine();
    //Ako se radi o prvom izvrsavanju j petelje, samo tada zelimo radjelnik odnosno "------------"
    if (i == 0) {
        Console.WriteLine(razdvojnik);
    }
}


//podnozje
//zelimo ga na samo kraju i zato ide izvan ugnježđenih petlji
Console.WriteLine(razdvojnik);
Console.Write(raz_dvotocka[^18..]);
Console.WriteLine(" :by Katarina");
Console.WriteLine(razdvojnik);

//prozor ostaje otvoren dok se ne unese enter
while (Console.ReadLine() == "/n") ;