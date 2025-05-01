using System;
using System.Text.RegularExpressions;

class ValidadorSenha
{
    public static void Executar()
    {
        Console.WriteLine("Digite sua senha para validação:");
        string? senha = Console.ReadLine();

        if (string.IsNullOrEmpty(senha))
        {
            Console.WriteLine("A senha não pode ser vazia.");
            return;
        }

        bool tamanhoMinimo = senha.Length >= 8;
        bool temMaiuscula = Regex.IsMatch(senha, "[A-Z]");
        bool temNumero = Regex.IsMatch(senha, "[0-9]");
        bool temCaractereEspecial = Regex.IsMatch(senha, "[!@#$%^&*(),.?\":{}|<>]");

        if (tamanhoMinimo && temMaiuscula && temNumero && temCaractereEspecial)
        {
            Console.WriteLine("Senha válida!");
        }
        else
        {
            Console.WriteLine("Senha fraca! Motivo:");
            if (!tamanhoMinimo)
                Console.WriteLine("- Deve ter pelo menos 8 caracteres.");
            if (!temMaiuscula)
                Console.WriteLine("- Deve conter pelo menos uma letra maiúscula.");
            if (!temNumero)
                Console.WriteLine("- Deve conter pelo menos um número.");
            if (!temCaractereEspecial)
                Console.WriteLine("- Deve conter pelo menos um caractere especial.");
        }
    }
}
