class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o exercício que deseja rodar:");
        Console.WriteLine("1 - Validador de Senha");
        Console.WriteLine("2 - Tabuada");
        Console.WriteLine("3 - Fatorial");
        Console.WriteLine("4 - Conversor de Temperatura");
        Console.WriteLine("5 - Palindromos");    
        Console.WriteLine("6 - Cadastro de Produtos");
        Console.WriteLine("7 - Soma de numeros pares");
        Console.WriteLine("8 - Calculadora de IMC");
        Console.WriteLine("9 - Jogo da Adivinhação");
        Console.WriteLine("10 - To Do List");


        

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                ValidadorSenha.Executar();
                break;
            case 2:
                Tabuada.Executar();
                break;
            case 3:
                Fatorial.Executar();
                break;
            case 4:
                ConversorTemperatura.Executar();
                break;
            case 5:
                Palindromos.Executar();
                break;
            case 6:
                CadastroProduto.Executar();
                break;
            case 7:
                SomaNumerosPares.Executar();
                break;
            case 8:
                CalculadoraIMC.Executar();
                break;
            case 9:
                JogoAdivinhacao.Executar();
                break;
            case 10:
                ListaDeTarefas.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
