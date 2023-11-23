namespace ToDoList
{
    internal class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("\n--- LISTA DE TAREFAS ---\n");
            Console.WriteLine("Escolha entre as opções abaixo:");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Ver tarefas");
            Console.WriteLine("3. Deletar tarefas");
            Console.WriteLine("4. Sair");
        }

        static void AddTask(List<string> tasks)
        {
            Console.WriteLine("Digite a tarefa a ser adicionada:");
            string? task = Console.ReadLine();

            tasks.Add(task!);
        }

        static void ViewTasks(List<string> tasks)
        {
            Console.WriteLine("Sua lista de tarefas:");
            for (int i = 0; i < tasks.Count; i++) Console.WriteLine($"{i + 1} - {tasks[i]}");
        }

        static void DeleteTask(List<string> tasks)
        {
            Console.WriteLine("Digite o número da tarefa a ser removida:");
            int task = int.Parse(Console.ReadLine()!);
            tasks.RemoveAt(task - 1);

            if (task < 1 || task > tasks.Count) Console.WriteLine("Tarefa não encontrada!");
        }

        static void Main(string[] args)
        {
            List<string> tasks = new();
            bool running = true;

            while (running)
            {
                ShowMenu();
                int option = int.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 1:
                        AddTask(tasks);
                        break;
                    case 2:
                        ViewTasks(tasks);
                        break;
                    case 3:
                        DeleteTask(tasks);
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}