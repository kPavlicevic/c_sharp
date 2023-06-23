// Zadatak 1
// Korisnik unosi cijeli broj
// Za broj manji od 10
// ispisuje se Osijek
// inače se ispisuje Donji Miholjac

Console.WriteLine("Unesi broj: ");
int broj=int.Parse(Console.ReadLine());
Console.WriteLine(broj < 10 ? "Osijek" : "Donji Miholjac");

// Zadatak 2
// Korisnik unosi cijeli broj
// Program ispisuje da li je 
// paran ili neparan

Console.WriteLine("Unesi broj: ");
broj=int.Parse(Console.ReadLine());
Console.WriteLine(broj % 2 == 0);
