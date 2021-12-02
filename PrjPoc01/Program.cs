using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjPoc01
{
    internal class Program
    {
        static List<Produto> ListaProduto = new List<Produto>();

        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("1 - Inserir\n2 - Listar\n3 - Sair");
            var inputChoice = Console.ReadLine();
            int choice = int.Parse(inputChoice);

            if (!ValidarMenu(choice))
            {
                return;
            }

                Repositorio repositorio = new Repositorio();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insira o produto no seguinte formato: \n" +
                                          "Codigo; Descrição; Valor; Tipo");
                        repositorio.InserirProduto(ListaProduto);
                        continue;
                    case 2:
                        Console.WriteLine("Produtos listados: \n");
                        repositorio.ListarProdutos(ListaProduto);
                        continue;
                    case 3:
                        Console.WriteLine("Programa finalizado.");
                        break;
                }
                break;
            }
        }

        private static bool ValidarMenu(int escolha)
        {
            int numero = escolha;
            if(numero > 3 || numero < 1)
            {
                Console.WriteLine("Selecione uma das opções disponíveis");
                return false;
            }
            return true;
        }
    }
}