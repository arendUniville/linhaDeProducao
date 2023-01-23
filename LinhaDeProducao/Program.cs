using System;
using System.Security.Cryptography;
using LinhaDeProducao.Entities;
using System.Globalization;
using LinhaDeProducao.Entities.Enums;

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

            int employeeId = 0;
            string employeeName;
            DateTime employeeBorn;
            double employeeSalary = 0.00;

            List<Product> products = new List<Product>();
            List<Employee> employees = new List<Employee>();
            


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

                        int quantityProductsAdd = 0;

                        Console.Write("How many products do you want to add? Quantity: ");
                        quantityProductsAdd = int.Parse(Console.ReadLine());

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

                            products.Add(new Product(productId, productName, productAmount, entryValue, outValue, serialId));

                            Console.Write("\nProduto adicionado!\n");



                        }

                        Console.Write("\nClick enter to continue. ");
                        Console.ReadLine();

                        Console.Write("Returnin to the main page in ");

                        for (int i = 3; i > 0; i--)
                        {

                            Console.Write(i);

                            Thread.Sleep(350);
                            Console.Write(".");
                            Thread.Sleep(350);
                            Console.Write(".");
                            Thread.Sleep(300);

                        }

                        Console.Clear();

                        break;

                    case 2:

                        int quantityEmployeeAdd = 0;

                        Console.Write("How many employee do you want to add? Quantity: ");
                        quantityEmployeeAdd = int.Parse(Console.ReadLine());

                        for (int i = 0; i < quantityEmployeeAdd; i++)
                        {

                            employeeId += 1;

                            Console.Write("Digite o nome do employee: ");
                            employeeName = Console.ReadLine();

                            Console.Write("Insira a data de nascimento: ");
                            employeeBorn = DateTime.Parse(Console.ReadLine());

                            Console.Write("Entry salary employee: R$ ");
                            employeeSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            employees.Add(new Employee(employeeId, employeeName, employeeBorn, employeeSalary, EmployeePosition.Auxiliary));

                            Console.Write("\nEmployee added!\n");



                        }

                        Console.Write("\nClick enter to continue. ");
                        Console.ReadLine();

                        Console.Write("Returnin to the main page in ");

                        for (int i = 3; i > 0; i--)
                        {

                            Console.Write(i);

                            Thread.Sleep(350);
                            Console.Write(".");
                            Thread.Sleep(350);
                            Console.Write(".");
                            Thread.Sleep(300);

                        }

                        Console.Clear();


                        break;

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

                        Console.Write("\nClick enter to continue. ");
                        Console.ReadLine();

                        Console.Clear();

                        break;

                    case 8:

                        Console.Clear();

                        Console.WriteLine("Employees registered:\n");

                        foreach (Employee e in employees)
                        {

                            Console.WriteLine(e.ToString() + "\n");
                            Console.WriteLine("------------------------------------");

                        }

                        Console.Write("\nClick enter to continue. ");
                        Console.ReadLine();

                        Console.Clear();

                        break;

                    case 9:

                        Console.Clear();
                        Console.Write("the program has been closed.");
                        return;

                    default:

                        Console.Clear();
                        Console.Write("Incorrect value. Returnin to the main page in ");

                        for (int i = 3; i > 0; i--)
                        {

                            Console.Write(i);

                            Thread.Sleep(350);
                            Console.Write(".");
                            Thread.Sleep(350);
                            Console.Write(".");
                            Thread.Sleep(300);

                        }

                        Console.Clear();

                        break;


                }

            }


            



        
        }
    }

}