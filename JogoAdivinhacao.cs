using System;

class JogoAdivinhacao
{
    public static void Executar()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int tentativas = 0;
        int palpite = 0;

        Console.WriteLine("Bem vindo ao jogo da adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        while (palpite != numeroAleatorio)
        {
            Console.Write("Digite seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroAleatorio)
            {
                Console.WriteLine("O número é maior. Tente novamente!");
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("O número é menor. Tente novamente!");
            }
            else
            {
                Console.WriteLine($"Parabéns, você acertou o número {numeroAleatorio} em {tentativas} tentativas.");
            }
        }
    }
}
