using System;
using System.Security.Cryptography;
using LinhaDeProducao.Entities;
using System.Globalization;

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
                Console.WriteLine("7. Mostrar produtos.");
                Console.WriteLine("8. Mostrar funcionários.");
                Console.WriteLine("9. Sair do programa.");

                Console.WriteLine("\n-------------------------------------");


                Console.Write("Escolha a opção desejada: ");
                userMenuChoice = int.Parse(Console.ReadLine());


                switch (userMenuChoice)
                {

                    case 1:

                        Console.Write("How many products do you want to add? Quantity: ");
                        int quantityProductsAdd = int.Parse(Console.ReadLine());

                        for(int i = 0;i < quantityProductsAdd; i++)
                        {

                            productId += 1;

                            Console.Write("Digite o nome do produto: ");
                            productName = Console.ReadLine();

                            Console.Write("Insira a quantidade em estoque: ");
                            productAmount = int.Parse(Console.ReadLine());

                            Console.Write("Insira o valor de custo: R$");
                            entryValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Insira o valor de venda: R$");
                            outValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Digite o lote do produto: ");
                            serialId = Console.ReadLine();

                            products.Add(new Product(productId, productName, productAmount, entryValue, outValue, "GBA001"));

                            Console.Write("\nProduto adicionado!\n");



                        }

                        Console.Write("Voltando a página inicial em ");

                        for (int i = 1; i <= 3; i++)
                        {

                            Console.Write(i + ", ");
                            Thread.Sleep(1000);

                        }

                        Console.Clear();

                        break;

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

                        Console.Clear();

                        Console.WriteLine("Produtos cadastrados:\n");

                        foreach(Product p in products)
                        {

                            Console.WriteLine(p.ToString());

                        }

                        Console.WriteLine("\nAperte enter para continuar. ");
                        Console.ReadLine();

                        Console.Clear();

                        break;

                    case 8:

                        break;

                    case 9:

                        Console.Clear();
                        Console.WriteLine("O programa foi encerrado.");
                        return;

                    default:

                        Console.Clear();
                        Console.WriteLine("Valor incorreto. Voltando ao início.");

                        for (int i = 0; i < 3; i++)
                        {

                            Console.WriteLine(i + ", ");
                            Thread.Sleep(1000);

                        }

                        Console.Clear();

                        break;


                }

            }


            



        
        }
    }

}