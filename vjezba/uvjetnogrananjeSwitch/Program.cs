// Zadatak 1
// Program unosi ime mjesta iz jedne od
// 4 slavonske županije
// Za uneseno ime mjesta program
// ispisuje ime županije


Console.WriteLine("Unesi ime grada: ");
string grad = Console.ReadLine();

switch (grad)
{
   case "Osijek":
        Console.WriteLine("Osječko-baranjska županija");
        break;
    case "Pleternica":
        Console.WriteLine("Požeško-slavonska županija");
        break;
    case "Ivankovo":
        Console.WriteLine("Vukovarsko-srijemska županija");
        break;
    case "Slavonski brod":
        Console.WriteLine("Brodsko-posavska županija");
        break;
    default:
        Console.WriteLine("nije grad");
        break;
}

