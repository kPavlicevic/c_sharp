Console.WriteLine("Unesite prvo ime:");
string ime1 = Console.ReadLine().ToLower();

Console.WriteLine("Unesite drugo ime:");
string ime2 = Console.ReadLine().ToLower();

string rez = ime1 + ime2;

int duljinaDuljegImena = ime1.Length <= ime2.Length ? ime2.Length : ime1.Length;

int[] sum1 = new int[duljinaDuljegImena];
int[] sum2 = new int[duljinaDuljegImena];

void printArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

for (int i = 0; i < duljinaDuljegImena; i++)
{
    sum1[i] = 0;
    sum2[i] = 0;
}


for (int i = 0; i < ime1.Length; i++)
{
    for (int j = 0; j < rez.Length; j++)
    {
        if (ime1[i] == rez[j])
        {
            sum1[i] += 1;
        }
    }
}
Console.Write("{0} :: ", ime1);
printArray(sum1);

for (int i = 0; i < ime2.Length; i++)
{
    for (int j = 0; j < rez.Length; j++)
    {
        if (ime2[i] == rez[j])
        {
            sum2[i] += 1;
        }
    }
}
Console.Write("{0}:: ", ime2);
printArray(sum2);

while (duljinaDuljegImena >= 2)
{
    Console.WriteLine("######################");
    int[] zbroj = new int[duljinaDuljegImena];
    Array.Reverse(sum2);
    for (int i = 0; i < duljinaDuljegImena; i++)
    {
        zbroj[i] = sum1[i] + sum2[i];
    }
    Console.Write("zbroj = ");
    printArray(zbroj);
    duljinaDuljegImena = duljinaDuljegImena / 2;
    sum1 = zbroj.Take(duljinaDuljegImena).ToArray();
    sum2 = zbroj.Skip(duljinaDuljegImena).ToArray();
    Console.Write("sum1 = ");
    printArray(sum1);
    Console.Write("sum2 = ");
    printArray(sum2);
}
if (sum1.Length < sum2.Length)
{
    int privremena = sum1[0];
    sum1 = new int[] { privremena, sum2[0] / 10 };
    sum2[0] = sum2[0] % 10;
}
else {
    sum1 = new int[] { sum1[0] / 10, sum1[0] % 10 };
    sum2 = new int[] { sum2[0] / 10, sum2[0] % 10 };
}
Console.WriteLine("##################");
Console.Write("sum1 = ");
printArray(sum1);
Console.Write("sum2 = ");
printArray(sum2);

int konacniPostotak = (sum1[0] + sum2[1]) * 10 + (sum1[1] + sum2[0]);
Console.WriteLine("konacni postotak: {0}%",konacniPostotak);










while (Console.ReadLine() != "0");