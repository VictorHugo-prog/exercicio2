int opcao;

do
{

    Console.WriteLine("Menu de Opções:");
    Console.WriteLine("1. Exibir uma mensagem");
    Console.WriteLine("2. Fazer uma soma");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha uma das opçôes acima: ");


    while (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Insira um número válido.");
        Console.Write("Escolha uma opção: ");
    }


    switch (opcao)
    {
        case 1:
            Console.WriteLine(" \nOlá! Mensagem");
            break;

        case 2:
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double soma = num1 + num2;
            Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
            break;

        case 3:
            Console.WriteLine("Saindo do programa. Até mais!");
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    } 

    Console.WriteLine();
} while (opcao != 3);

Console.WriteLine("pressione uma tecla para encerrar o programa");
Console.ReadKey();


