using System;
using todolist;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        User user = null;
        int started = 0;

        while (i != 0)
        {
            if (started == 0)
            {
                Console.WriteLine("Digite o seu nome: ");
                string nome = Console.ReadLine();
                int id = BusinessSevice.GenerateId();
                user = new User(nome, id);
            }

            Console.WriteLine("Deseja adicionar quantas tarefas? (1-5)");
            if (!int.TryParse(Console.ReadLine(), out int taskNum))
            {
                Console.WriteLine("Valor inválido! Digite um número.");
                continue;
            }

            if (taskNum < 1 || taskNum > 5)
            {
                Console.WriteLine($"Quantidade {taskNum} não permitida. Digite de 1 a 5.");
                continue;
            }

            BusinessSevice.AddTasks(taskNum, user);

            Console.WriteLine("Digite a operação que deseja: \n1 - Visualizar tarefas \n2 - Salvar em arquivo \n3 - Remover tarefa");
            if (!int.TryParse(Console.ReadLine(), out int op))
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }

            BusinessSevice.TasksOperation(op, user);

            Console.WriteLine("Deseja encerrar? Digite 0 (Zero) para sair ou qualquer número para continuar");
            if (!int.TryParse(Console.ReadLine(), out i))
            {
                i = 1;
            }

            started++;
        }

        Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}