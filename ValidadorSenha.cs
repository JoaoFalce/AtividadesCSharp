using System;
using System.Text.RegularExpressions;

class ValidadorSenha
{
    public static void Executar() // Ponto de entrada do programa
    {
    {
        // Mostro uma mensagem explicando o que o programa faz e seus critérios
        Console.WriteLine("=== Validador de Senhas Fortes ===");
        Console.WriteLine("A senha deve conter:");
        Console.WriteLine("• Mínimo de 8 caracteres");
        Console.WriteLine("• Pelo menos uma letra maiúscula");
        Console.WriteLine("• Pelo menos um número");
        Console.WriteLine("• Pelo menos um caractere especial (ex: !, @, #, $, %, ^, &, *)");
        Console.WriteLine();
        
        // Peço para o usuário digitar a senha
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine(); // captura a senha
        
        // Primeiro vejo se tem 8 caracteres no mínimo
        if (senha.Length >= 8)
        {
            // Se tiver 8 chars, vou ver se tem pelo menos uma letra maiúscula
            // Isso procura qualquer letra de A até Z (maiúsculas)
            if (Regex.IsMatch(senha, "[A-Z]"))
            {
                // Se chegou aqui, é porque já tem 8+ chars e uma maiúscula
                // Então verifico se tem números (qualquer dígito de 0 a 9)
                if (Regex.IsMatch(senha, "[0-9]"))
                {
                    // Por último, preciso ter certeza que tem caracteres especiais
                    // Essa expressão meio confusa é só uma lista de símbolos
                    if (Regex.IsMatch(senha, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]"))
                    {
                        // Passou em tudo! A senha é boa.
                        Console.WriteLine("Senha válida!");
                    }
                    else
                    {
                        // Faltou caractere especial
                        Console.WriteLine("Sua senha deve conter pelo menos um caractere especial, uma letra maiúscula e um número!");
                    }
                }
                else
                {
                    // Faltou número
                    Console.WriteLine("Senha inválida!");
                }
            }
            else
            {
                // Faltou letra maiúscula
                Console.WriteLine("Senha inválida!");
            }
        }
        else
        {
            // Menos de 8 caracteres
            Console.WriteLine("Senha inválida!");
        }
        
        // Não deixo o programa fechar automaticamente
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey(); // Aguarda o usuário pressionar qualquer tecla
    }
}
}


/*O passo a passo lógico para a resolução

Apresentação
O exercício começa exercendo uma explicação e objetiva com os requisitos para uma senha inválida, nesse contexto é possível observar o que o usuário se espera antes mesmo da solicitação de entrada.
Entrada do Usuário
O programa solicita a senha e captura pelo usuário através do console

Validação
Dentro da validação ocorre um processo de verificações, onde casa requisito é testado separadamente, entre eles, apresenta a verificação do comprimento ( 8 caracteres ), letra maiúscula ( verificar se tem a presença de uma letra maiúscula ), números ( verificar se possui pelo menos um número ) e caractere especial ( verifica se possui caractere especial ). Se qualquer critério falhar, o programa informa que a senha é inválida.

Resultado
O programa fornece dois resultados:
"Senha valida" ( se os critérios forem atendidos ).
"Senha inválida" ( se os critérios não forem atendidos ).

Finalização
O programa aguarda que o usuário pressione uma tecla antes de encerrar.
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Justificativas do Método Adotado

Condicionais aninhadas
A utilização de condicionais aninhadas se mostrou adequada para garantir que cada critério de validação seja analisado em sequência, interrompendo o processo assim que uma regra não seja atendida. Isso ajuda a evitar processamento desnecessário e simplifica a lógica. Por exemplo, se a senha já não tiver o comprimento mínimo necessário, não faz sentido verificar os demais critérios. Além disso, essa estrutura torna o código visualmente mais claro, já que cada validação é conectada em um fluxo lógico.

Ordem das verificações
A sequência escolhida começa pelas validações mais simples, como o tamanho da senha, que exige apenas uma comparação numérica. Essa é uma operação leve e rápida, sendo eficiente priorizá-la. Depois, as verificações mais complexas, como a presença de caracteres especiais ou números, entram em cena. Isso evita executar operações desnecessárias e reflete a forma como muitos sistemas lidam com validações: as regras básicas primeiro, seguidas das mais específicas.

Expressões regulares
Expressões regulares foram utilizadas por sua eficiência em detectar padrões no texto. Por exemplo, para saber se uma senha contém pelo menos um número, uma única linha de código com uma expressão regular resolve o problema de forma direta, sem a necessidade de criar loops ou condições adicionais. Além disso, essa abordagem é amplamente usada na área, tornando o código mais alinhado com práticas profissionais.

Resultado binário simples
A opção de retornar apenas "válida" ou "inválida" foi feita para manter o foco no objetivo principal: indicar se a senha atende ou não aos critérios.*/

