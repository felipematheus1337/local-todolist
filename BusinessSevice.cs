using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace todolist
{
    class BusinessSevice
    {

        public static void AddTasks(int num, User user)
        {
            user.tasks ??= new List<Tarefa>();
            while (num > 0)
            {
                Console.WriteLine("Digite a descrição da tarefa de numero - " + num + " :");
                string description = Console.ReadLine();

                user.tasks.Add(new Tarefa(GenerateId(), description));

                num--;
            }
        }

        public static int GenerateId()
        {
            Random rnd = new Random();
            return rnd.Next();
        }

        internal static void TasksOperation(int op, User user)
        {
            switch (op)
            {
                case 1:
                    user.tasks.ForEach(t => Console.WriteLine($"{t.id} + {t.description} + {t.status}"));
                    break;
                case 2:
                    Console.WriteLine("Digite 1 para salvar em txt e 2 para salvar em json");
                    if (!int.TryParse(Console.ReadLine(), out int fileOp))

                        if(fileOp == 1)
                        {
                            string txtFilePath = Path.Combine(Directory.GetCurrentDirectory(), "tasks.txt");

                            var lines = user.tasks.Select(t => $" {t.id} - {t.description} - {t.status}").ToList();

                            File.WriteAllLines(txtFilePath, lines);
                            Console.WriteLine($"Tarefas salvas com sucesso em {txtFilePath}");


                        } else if (fileOp == 2)
                        {
                            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "tasks.json");
                            string jsonContent = JsonSerializer.Serialize(user.tasks, new JsonSerializerOptions
                            {
                                WriteIndented = true
                            });

                            File.WriteAllText(jsonFilePath, jsonContent);
                            Console.WriteLine($"Tarefas salvas em JSON com sucesso em {jsonFilePath}");

                        } else
                        {
                            Console.WriteLine("Operação invalida!");
                        }

                            break;
                case 3:
                    Console.WriteLine("Digite o id da task que deseja remover: ");
                    int id = int.Parse(Console.ReadLine());
                    user.tasks.RemoveAll(t => t.id == id);
                    break;
                default:
                    Console.WriteLine("Operacao nao encontrada!");
                    break;


            }
            
        }
    }
}
