using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarefa
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int seq = 1;
            List<Tarefa> lstTask = new List<Tarefa>();


            Console.WriteLine("Cadastro de Tarefas");
            do
            {
                Console.WriteLine("\nDigite a opção desejada:\n\n[1] Cadastrar Tarefas\n[2] Consultar Tarefas\n[3] Consultar por Id\n[4] Editar Tarefa\n[5] Excluir Tarefa\n[6] Ordenar Tarefas por Nome\n[7] Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1) // Cadastrar
                {
                    Tarefa task = new Tarefa();                  
                    task.Id = seq;

                    Console.WriteLine("Digite o título da tarefa:");
                    task.Titulo = Console.ReadLine();

                    Console.WriteLine("Digite a descrição da tarefa:");
                    task.Descricao = Console.ReadLine();

                    Console.WriteLine("Digite a data prevista de conclusão da tarefa:");
                    task.DataPrevista = Console.ReadLine();

                    task.StatusTarefa = Convert.ToInt32(StatusTarefaEnum.Pendente);

                    Console.WriteLine("Tarefa cadastrada com sucesso!");
                    lstTask.Add(task);

                    seq++;
                }
                else if (opcao == 2) // Consultar
                {
                    Console.WriteLine("\nTarefas cadastradas: ");

                    foreach (var item in lstTask)
                    {
                        Console.WriteLine("Id: " + item.Id + " | Título: " + item.Titulo + " | Status: " + item.StatusTarefa);
                    }
                }
                else if (opcao == 3) // Consultar por Id
                {
                    Console.WriteLine("Informe o id da tarefa: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    var tal = lstTask.Find(x => x.Id == codigo);
                    Console.WriteLine("Título: " + tal.Titulo + " | Status: " + tal.StatusTarefa + " | Data prevista: " + tal.DataPrevista);
                }
                else if (opcao == 4) // Alterar
                {
                    Console.WriteLine("Informe o id da tarefa para edição: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    var tal = lstTask.Find(x => x.Id == codigo);

                    Console.WriteLine("Informe o novo título: ");
                    tal.Titulo = Console.ReadLine();

                    Console.WriteLine("Informe a nova descrição: ");
                    tal.Descricao = Console.ReadLine();

                    Console.WriteLine("Informe a nova data prevista: ");
                    tal.DataPrevista = Console.ReadLine();

                    Console.WriteLine("Informe o novo status: ");
                    tal.StatusTarefa = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Registro alterado com sucesso!");
                }
                else if (opcao == 5) // Remover
                {
                    Console.WriteLine("Informe o id da tarefa para exclusão: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    var tal = lstTask.Find(x => x.Id == codigo);
                    lstTask.Remove(tal);

                    Console.WriteLine("Registro removido com sucesso!");
                }
                else if (opcao == 6) // Ordernar lista
                {
                    lstTask = lstTask.OrderBy(x => x.Titulo).ToList();
                }


            } while (opcao != 7);


        }
    }
}
