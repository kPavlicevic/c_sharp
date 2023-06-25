int i = 2;

if (i == 1)
{
    Console.WriteLine("Dobro");
}
else if (i == 2)
{
    Console.WriteLine("Ok");
}
else 
{
    Console.WriteLine("Ostalo");
}


// višestruko grananje

int ocjena = 3;

switch (ocjena) 
{
    case 1:
        Console.WriteLine("Nedovoljan");
        break;
    case 2:
        Console.WriteLine("Dovoljan");
        break;
    case 3:
        Console.WriteLine("Dobar");
        break;
    case 4:
        Console.WriteLine("Vrlo dobar");
        break;
    case 5:
        Console.WriteLine("Odlično");
        break;
    default:
        Console.WriteLine("Nije ocjena");
        break;
}
