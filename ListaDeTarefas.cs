using System;
using System.Collections.Generic;

class ListaDeTarefas
{
    public static void Executar()
    {
        List<string> tarefas = new List<string>();
        string opcao;

        do
        {
            Console.WriteLine("\n1 - Adicionar Tarefa");
            Console.WriteLine("2 - Exibir Tarefas");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Digite a tarefa: ");
                string tarefa = Console.ReadLine();
                tarefas.Add(tarefa);
            }
            else if (opcao == "2")
            {
                Console.WriteLine("\nTarefas:");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i]}");
                }
            }

        } while (opcao != "3");

        Console.WriteLine("saindo...");
    }
}
