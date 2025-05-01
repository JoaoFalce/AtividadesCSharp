using System;

class ConversorTemperatura
{
    public static void Executar()
    {
        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("\n--- Conversor de Temperaturas ---");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    if (double.TryParse(Console.ReadLine(), out double celsius))
                    {
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine($"Resultado: {celsius}°C = {fahrenheit}°F");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    if (double.TryParse(Console.ReadLine(), out double fahr))
                    {
                        double cels = (fahr - 32) * 5 / 9;
                        Console.WriteLine($"Resultado: {fahr}°F = {cels}°C");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
