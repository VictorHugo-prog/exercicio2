Console.WriteLine("Digite o número de um mês para saber sua respectiva estação do ano: ");
int numeroEscolhido = int.Parse(Console.ReadLine());

string v = "Verão";
string o = "Outono";
string p = "Primavera";
string i = "Inverno";

switch (numeroEscolhido)
{
    case 1:
        Console.WriteLine($"Você escolheu o mês de Janeiro e sua estação respectiva é: {v}");
        break;

    case 2:
        Console.WriteLine($"Você escolheu o mês de Fevereiro e sua estação respectiva é: {v}");
        break;

    case 3:
        Console.WriteLine($"Você escolheu o mês de Março e sua estação respectiva é: {o}");
        break;
    case 4:
        Console.WriteLine($"Você escolheu o mês de Abril e sua estação respectiva é: {o}");
        break;

    case 5:
        Console.WriteLine($"Você escolheu o mês de Maio e sua estação respectiva é: {o}");
        break;

    case 6:
        Console.WriteLine($"Você escolheu o mês de Junho e sua estação respectiva é: {i}");
        break;

    case 7:
        Console.WriteLine($"Você escolheu o mês de Julho e sua estação respectiva é: {i}");
        break;

    case 8:
        Console.WriteLine($"Você escolheu o mês de Agosto e sua estação respectiva é: {i}");
        break;

    case 9:
        Console.WriteLine($"Você escolheu o mês de Setembro e sua estação respectiva é: {p}");
        break;

    case 10:
        Console.WriteLine($"Você escolheu o mês de Outubro e sua estação respectiva é: {p}");
        break;

    case 11:
        Console.WriteLine($"Você escolheu o mês de Novembro e sua estação respectiva é: {p}");
        break;

    case 12:
        Console.WriteLine($"Você escolheu o mês de Dezembro e sua estação respectiva é: {v}");
        break;

    default:
        Console.WriteLine("O número escolhido não é permetido");
        break;
}
Console.WriteLine("Digite qualquer tecla para encerrar o programa");
Console.ReadKey();