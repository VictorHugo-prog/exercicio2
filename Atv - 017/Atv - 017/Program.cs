int numero;

Console.Write("Digite um numero inteiro positivo: ");

while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
{
    Console.WriteLine("Por favor, insira um numero inteiro positivo: ");
    Console.Write("Digite um numero inteiro positivo"); 
}

Console.WriteLine($"Numeros impares ate {numero} são: ");
for (int i = 1; i <= numero; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Digite qualquer tecla para encerrar o programa");
Console.ReadKey();