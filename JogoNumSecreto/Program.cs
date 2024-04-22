
// int numSecreto = 33;
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

Console.WriteLine("Bem Vindo ao Jogo do Numero Secreto! ");
String agrado = Console.ReadLine()!;

do
{
    Console.Write("Digite um numero de 1 a 100: ");
    int chute = int.Parse(Console.ReadLine()!);

    if (chute == numeroSecreto)
    {
        Console.WriteLine($"Parabéns você acertou o numero secreto: {numeroSecreto}");
        break;
    } else if (chute < numeroSecreto) {
        Console.WriteLine("O numero e maior");
    }
    else
    {
        Console.WriteLine("O numero e menor");
    }
} while (true);
Console.WriteLine($"O jogo acabou. Você acertou o numero secreto que era {numeroSecreto}"); 