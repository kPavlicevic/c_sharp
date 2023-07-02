
int redaka = 5, stupaca = 5;


Console.Write("Unesi broj redova: ");
redaka = int.Parse(Console.ReadLine());

Console.Write("Unesi broj stupaca: ");
stupaca = int.Parse(Console.ReadLine());

int[,] matrica = new int[redaka, stupaca];

int b = 1;

for (int i = 1; i <= stupaca; i++)
{
    matrica[redaka - 1, stupaca - i] = b++;
}

//    // i= 1  - matrica[4,4]
//    // i= 2  - matrica[4,3]
//    // i= 3  - matrica[4,2]
//    // i= 4  - matrica[4,1]
//    // i= 5  - matrica[4,0]


for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("*********");

for (int i = redaka - 2; i >= 0; i--)
{
    matrica[i, 0] = b++;
    // i= 3  - matrica[3,0]
    // i= 2  - matrica[2,0]
    // i= 1  - matrica[1,0]
    // i= 0  - matrica[0,0]

}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("*********");
for (int i = 1; i < stupaca; i++) 
{
    matrica[0, i] = b++;
}


for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
        
    }
    Console.WriteLine();
}


Console.WriteLine("*********");
for (int i = 1; i <= redaka - 2; i++)
{
    matrica[i, 4] = b++;
}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("*********");
for (int i = 3; i >= stupaca - 4; i--)
{
    matrica[3, i] = b++;

}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("*********");
for (int i = 2; i >= redaka - 4; i--)
{
    matrica[i, 1] = b++;

}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("*********");
for (int i = 2; i <= stupaca - 2; i++)
{
    matrica[1, i] = b++;

}

for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("*********");
for (int i = 3; i >= stupaca - 3; i--)
{
    matrica[2, i] = b++;

}

string ispis;
for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        ispis = "  " + matrica[i, j];
        Console.Write(ispis[^3..]);
    }
    Console.WriteLine();
}







