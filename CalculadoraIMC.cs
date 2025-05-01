using System;

class CalculadoraIMC
{
    public static void Executar()
    {
        Console.Write("Digite seu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine($"\nSeu IMC é: {imc:F1}");

        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Classificação: Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade");
        }
    }
}
