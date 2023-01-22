using System;
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

                        string productName;

                        // Gerando número aleatório.

                            int baseDivide = 233366699;

                            DateTime d1 = DateTime.Now;

                            int d2 = DateTime.Now.Hour;
                            int d3 = DateTime.Now.Minute;
                            int d4 = DateTime.Now.Second;
                            int d5 = DateTime.Now.Millisecond;

                            //Console.WriteLine(d1);
                            //Console.WriteLine(d1.Ticks);
                            //Console.WriteLine(d2);

                            int productId = (((int)d1.Ticks + d2) * d4) + d5;


                        Console.Write("Digite o nome do produto: ");
                        productName = Console.ReadLine();


                        products.Add(new Product(productId, productName, 5, 2.50, 5.53, "GBA001"));



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