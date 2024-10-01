Console.Write("Digite a nota do aluno (0 a 100): ");
string nota2 = Console.ReadLine();
if (double.TryParse(nota2, out double nota))
{
    if (nota >= 90 && nota <= 100)
    {
        Console.WriteLine("Classificação: A");
    }
    else if (nota >= 80 && nota < 90)
    {
        Console.WriteLine("Classificação: B");
    }
    else if (nota >= 70 && nota < 80)
    {
        Console.WriteLine("Classificação: C");
    }
    else if (nota >= 60 && nota < 70)
    {
        Console.WriteLine("Classificação: D");
    }
    else if (nota < 60 && nota >= 0)
    {
        Console.WriteLine("Classificação: F");
    }
    else
    {
        Console.WriteLine("Nota inválida. Por favor, insira uma nota entre 0 e 100.");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
}

Console.WriteLine("Digite qualquer tecla para encerrar o programa");
Console.ReadKey();
