Console.Write("Digite um número inteiro positivo: ");

if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
{
    int fatorial = 1; 

   
    for (int i = 1; i <= numero; i++)
    {
        fatorial *= i; 
    }

    
    Console.WriteLine($"O fatorial de {numero} é  = {fatorial}");
}
else
{
    Console.WriteLine("Insira um número inteiro positivo.");
}

Console.WriteLine("Digite qualquer tecla para encerrar o programa");
Console.ReadKey();