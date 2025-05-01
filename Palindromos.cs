using System;
using System.Text;
using System.Globalization;

class Palindromos
{
    public static void Executar()
    {
        Console.WriteLine("Digite uma palavra ou frase para verificar se é um palíndromo:");
        string entrada = Console.ReadLine();

        // remove espaços, acentos e converte para minúsculas
        string textoTratado = RemoverAcentos(entrada.ToLower().Replace(" ", ""));

        // inverte o texto
        string textoInvertido = new string(textoTratado.Reverse().ToArray());

        if (textoTratado == textoInvertido)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }
    public static string RemoverAcentos(string texto)
    {
        var textoNormalizado = texto.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (var c in textoNormalizado)
        {
            var unicode = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicode != UnicodeCategory.NonSpacingMark)
            {
                sb.Append(c);
            }
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}
