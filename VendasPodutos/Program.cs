﻿using System;
using System.Globalization;
using VendasPodutos;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Produto p = new Produto();
                
                Console.WriteLine("Entre os dados do produto: ");
                Console.Write("Nome: ");
                p.Nome = Console.ReadLine();
                Console.Write("Preço: ");
                p.Preco = double.Parse(Console.ReadLine(), CI);
                Console.Write("Quantidade: ");
                p.Quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Dados do produto: " + p);

                Console.WriteLine();
                Console.Write("Digite o numero de produto a ser adicionado no estoque: ");
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);

                Console.WriteLine();
                Console.WriteLine("Dados do produto Atualizados: " + p);

                Console.WriteLine();
                Console.WriteLine("Digite o numero de produto a ser removido no estoque: ");
                qte = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qte);
                Console.WriteLine("Dados do produto Atualizados: " + p);

            }
        }
    }
}