using System;

namespace Grupo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("\n\n Digite a opção desejada: \n[1] Cadastrar Grupo;\n[2] Cancelar.");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Informe o nome do grupo: ");
                    string nomeGrupo = Console.ReadLine();

                    Console.WriteLine("Informe a descrição do grupo: ");
                    string descGrupo = Console.ReadLine();

                    Grupo grp = new Grupo();

                    grp = grp.CadastrarGrupo(nomeGrupo, descGrupo);

                    Console.WriteLine("\n\nGrupo cadastrado com sucesso!\nNOME: " + grp.Nome + "\nDESCRIÇÃO: " + grp.Descricao);
                }

            } while (opcao != 2);

        }
    }
}
