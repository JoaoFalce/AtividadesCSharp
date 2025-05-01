using System;

class Fatorial
{
    public static void Executar()
    {
        Console.WriteLine("Digite um número inteiro positivo para calcular o fatorial:");
        int numero;
        
        // verificar se o número é positivo
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo.");
        }

        // se o numero for 0, o fatorial é 1
        int fatorial = 1;

        // calculando  fatorial usando while
        int contador = numero;
        while (contador > 1)
        {
            fatorial *= contador;
            contador--;
        }

        Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
    }
}
