int numeroSecreto = 7;
int palpite;
bool acertou = false;

do
{
    Console.Write("Adivinhe o número secreto (entre 1 e 10): ");
    palpite = int.Parse(Console.ReadLine());

    if (palpite == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você adivinhou o número secreto.");
        acertou = true;
    }
    else
    {
        Console.WriteLine("Tente novamente.");
    }
} while (!acertou);

Console.Write("Digite qualquer tecla para encerrar o programa");
Console.ReadKey();