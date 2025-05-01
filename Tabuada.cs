using System;

class Tabuada
{
    public static void Executar()
    {
        Console.WriteLine("Digite um número de 1 a 10 para exibir sua tabuada:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tabuada do {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
