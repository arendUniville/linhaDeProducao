using System;
using System.Security.Cryptography;
using LinhaDeProducao.Entities;

namespace LinhaDeProducao
{

    class Program
    {

        static void Main(string[] args) 
        {

            Console.WriteLine("Bem vindo ao sistema de linha de produção.");

            bool userWantContinue = true;
            int userMenuChoice;
            
            int productId = 0;
            string productName;
            int productAmount = 0;
            double entryValue;
            double outValue;
            string serialId;

            List<Product> products = new List<Product>();


            while (userWantContinue)
            {

                Console.WriteLine("\n-------------------------------------\n");

                Console.WriteLine("1. Registrar um produto.");
                Console.WriteLine("2. Registrar um funcionário.");
                Console.WriteLine("3. Iniciar uma produção.");
                Console.WriteLine("4. Excluir uma produção.");
                Console.WriteLine("5. Mostrar faturamento.");
                Console.WriteLine("6. Mostrar produção em andamento.");
                Console.WriteLine("7. Sair do programa.");

                Console.WriteLine("\n-------------------------------------");

                Console.Write("Escolha a opção desejada: ");
                userMenuChoice = int.Parse(Console.ReadLine());



                switch (userMenuChoice)
                {

                    case 1:

                        productId += 1;

                        Console.Write("Digite o nome do produto: ");
                        productName = Console.ReadLine();

                        Console.Write("Insira a quantidade em estoque: ");
                        productAmount = int.Parse(Console.ReadLine());

                        Console.Write("Insira o valor de custo: R$");
                        entryValue = double.Parse(Console.ReadLine());

                        Console.Write("Insira o valor de venda: R$");
                        outValue = double.Parse(Console.ReadLine());

                        Console.Write("Digite o lote do produto: ");
                        serialId = Console.ReadLine();

                        products.Add(new Product(productId, productName, productAmount, entryValue, outValue, "GBA001"));



                        return;

                    case 2:
                        return;

                    case 3:
                        return;

                    case 4:
                        return;

                    case 5:

                        return;

                    case 6:

                        return;

                    case 7:

                        Console.WriteLine("O programa foi encerrado.");
                        return ;

                }





            }






        
        }
    }

}