using System;

class Tabuada
{
    public static void Executar()
    {
        // Exibe o título do programa e solicito entrada ao usuário
            Console.WriteLine("=== CALCULADORA DE TABUADA ===");
            Console.Write("Digite um número para ver sua tabuada: ");
            
            // Tenta converter a entrada do usuário para um número inteiro
            if (int.TryParse(Console.ReadLine(), out int numero)) // Se a conversão for bem-sucedida
            {
                Console.WriteLine($"\nTabuada do {numero}:"); // Exibe o cabeçalho da tabuada
                Console.WriteLine("--------------------"); // Linha separadora para melhorar visualização
                
                // Inicia um laço que vai de 1 até 10
                for (int i = 1; i <= 10; i++) // i começa em 1, continua enquanto for <= 10, incrementa 1 a cada iteração
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}"); // Calcula e exibe cada linha da tabuada
                }
            }
            else // Se a conversão falhar (entrada não for um número válido)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido."); // Mensagem de erro
            }
            
            Console.WriteLine("\nPressione qualquer tecla para sair..."); // Instrução final para o usuário
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de encerrar
        }
    }


/*Passo a Passo Lógico para a Resolução

Apresentação
O programa começa com o título "CALCULADORA DE TABUADA", exibido no console. Isso informa ao usuário que o objetivo do programa é gerar a tabuada de um número dado pelo usuário.

Entrada do Usuário
O usuário é solicitado a digitar um número inteiro. Essa entrada é capturada como texto pelo método Console.ReadLine(). Para garantir que o dado possa ser utilizado no cálculo, é realizada uma conversão para o tipo int.

Validação da Entrada
A validação utiliza o método int.TryParse(), que verifica se o texto fornecido pelo usuário pode ser convertido em um número inteiro.
Se a conversão for bem-sucedida, o programa prossegue para o cálculo da tabuada. Caso contrário, exibe uma mensagem indicando que a entrada foi inválida e solicita um número inteiro válido.

Processamento (Cálculo da Tabuada)
O cálculo da tabuada é realizado dentro de um laço for que vai de 1 a 10, refletindo a convenção padrão de tabuadas. O laço é controlado pela variável i, que representa o multiplicador em cada iteração. Em cada passo do laço, o produto do número fornecido e i é calculado e exibido no formato "número x i = resultado".

Resultado
Após concluir o cálculo, o programa exibe todas as linhas da tabuada no console. Cada linha mostra o número multiplicado por i, seguido do resultado, oferecendo uma saída organizada e legível.

Finalização
Antes de encerrar, o programa exibe uma mensagem final: "Pressione qualquer tecla para sair...". O comando Console.ReadKey() é usado para pausar a execução até que o usuário pressione uma tecla, permitindo que ele veja os resultados antes de o programa fechar.
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Justificativas do Método Adotado

Validação com int.TryParse()
A utilização de int.TryParse() para validar a entrada é uma escolha prática. Esse método verifica se a entrada é um número inteiro válido, garantindo que o programa opere apenas com dados apropriados. Além disso, a validação evita que o programa lance exceções caso o usuário insira um dado inválido.

Laço for para o cálculo da tabuada
O laço for foi escolhido devido à sua adequação para situações onde o número de iterações é conhecido previamente. Neste caso, a tabuada tradicional tem 10 linhas (de 1 a 10), o que torna o for ideal para controlar o cálculo e exibição de forma eficiente.

Uso de interpolação de strings
A interpolação de strings com o formato ${numero} x {i} = {numero * i} torna o código mais legível e facilita a exibição dos resultados. Essa abordagem é preferível ao uso de concatenação de strings, pois melhora a clareza do código.

Mensagens claras para o usuário
O programa apresenta mensagens detalhadas tanto em caso de sucesso quanto de erro na entrada do usuário.

Aguardo antes de encerrar
O uso de Console.ReadKey() antes de finalizar o programa é essencial para garantir que o usuário veja os resultados antes do encerramento, especialmente em ambientes onde o console fecha imediatamente após o término da execução.*/
