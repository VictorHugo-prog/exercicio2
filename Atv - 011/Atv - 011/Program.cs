try
{
    Console.Write("Digite o primeiro numero: "); 
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo numero: ");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = num1 + num2;
    Console.WriteLine($"O resultado da soma de {num1} mais {num2} é: {resultado}");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos");
}

Console.WriteLine("Aperte  ais uma tecla para encerrar o progama");
Console.ReadKey();