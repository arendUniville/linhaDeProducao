using System;
using System.Security.Cryptography;
using LinhaDeProducao.Entities;
using System.Globalization;
using LinhaDeProducao.Entities.Enums;
using System.Xml.Linq;

namespace LinhaDeProducao
{

    class Program
    {

        static void Main(string[] args) 
        {

            Console.WriteLine("Bem vindo ao sistema de linha de produção.\n");

            bool userWantContinue = true;
            int userMenuChoice = 0;
            bool isNumber;
            bool isRestart = false;
            
            //Product
            int productId = 0;
            string productName;
            int productAmount = 0;
            double entryValue;
            double outValue;
            string serialId;

            //Employee
            int employeeId = 0;
            string employeeName;
            DateTime employeeBorn;
            double employeeSalary = 0.00;

            //Production
            int productionId = 0;
            string productionName;
            string productionEmployeeName = "";
            int productionProductName;
            DateTime productionInitDate;
            DateTime productionPreviousDate;
            DateTime productionRealDate;
            int productionEmployee = 0;

            double productionCost = 0.00;
            double productionValue = 0.00;

            List<Product> products = new List<Product>();
            List<Employee> employees = new List<Employee>();
            List<ProductionOrder> orders = new List<ProductionOrder>();
            


            while (userWantContinue)
            {

                isRestart = false;

                Console.WriteLine("-------------------------------------\n");

                Console.WriteLine("1. Registrar um produto.");
                Console.WriteLine("2. Registrar um funcionário.");
                Console.WriteLine("3. Iniciar uma produção.");
                Console.WriteLine("4. Excluir uma produção.");
                Console.WriteLine("5. Mostrar finanças.");
                Console.WriteLine("6. Mostrar produção em andamento.");
                Console.WriteLine("7. Mostrar produtos.");
                Console.WriteLine("8. Mostrar funcionários.");
                Console.WriteLine("9. Sair do programa.");

                Console.WriteLine("\n-------------------------------------");


                Console.Write("Escolha a opção desejada: ");
                string userMenuChoiceString = Console.ReadLine();

                isNumber = int.TryParse(userMenuChoiceString,out userMenuChoice);

                if(isNumber)
                {

                    userMenuChoice = int.Parse(userMenuChoiceString);

                }
                else
                {

                    isRestart = true;

                    Console.Write("The value inserted is not a valid value. Restarting program in ");

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

                }

                Thread.Sleep(350);
                Console.Clear();


                if (!isRestart)
                {

                    switch (userMenuChoice)
                    {

                        case 1:

                            Console.WriteLine("REGISTER PRODUCT\n");

                            int quantityProductsAdd = 0;

                            Console.Write("How many products do you want to add? Quantity: ");
                            quantityProductsAdd = int.Parse(Console.ReadLine());

                            for (int i = 0; i < quantityProductsAdd; i++)
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

                            Console.Clear();

                            break;

                        case 2:

                            Console.WriteLine("REGISTER EMPLOYEE\n");

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

                            Console.Clear();


                            break;

                        case 3:

                            Console.WriteLine("REGISTER ORDER\n");

                            int quantityProductionOrderAdd = 0;

                            Console.Write("How many orders do you want to add? Quantity: ");
                            quantityProductionOrderAdd = int.Parse(Console.ReadLine());

                            for (int i = 0; i < quantityProductionOrderAdd; i++)
                            {

                                productionId += 1;

                                Console.WriteLine("Entry name production:");
                                productionName = Console.ReadLine();

                                Console.WriteLine("Entry id product: ");
                                productionProductName = int.Parse(Console.ReadLine());

                                productionInitDate = DateTime.Now;

                                Console.WriteLine("Entry Previous Date: ");
                                productionPreviousDate = DateTime.Parse(Console.ReadLine());

                                productionRealDate = productionPreviousDate;

                                Console.WriteLine("Entry id employe responsible: ");
                                productionEmployee = int.Parse(Console.ReadLine());

                                foreach (Employee m in employees)
                                {

                                    if (productionEmployee == m.Id)
                                    {

                                        productionEmployeeName = m.FirstName.ToString();

                                    }
                                    else
                                    {

                                        productionEmployeeName = "Employee not founded.";

                                    }

                                }

                                Console.WriteLine("Cost: ");
                                productionCost = double.Parse(Console.ReadLine());

                                Console.WriteLine("Value: ");
                                productionValue = double.Parse(Console.ReadLine());


                                ProductionStatus productionStatus = ProductionStatus.Pendent;

                                orders.Add(
                                    new ProductionOrder(productionId,
                                                        productionName,
                                                        productionProductName,
                                                        productionInitDate,
                                                        productionPreviousDate,
                                                        productionRealDate,
                                                        productionEmployee.ToString(),
                                                        productionStatus,
                                                        productionCost,
                                                        productionValue
                                                        ));

                                Console.WriteLine($"Production order number {productionId} with employee {productionEmployeeName}");

                            }

                            Console.Write("\nClick enter to continue. ");
                            Console.ReadLine();

                            Console.Clear();

                            break;

                        case 4:

                            Console.Write("\nClick enter to continue. ");
                            Console.ReadLine();

                            Console.Clear();

                            break;

                        case 5:

                            Console.Clear();

                            Console.WriteLine("Money information:\n");

                            double totalValueFatured = 0.00;
                            double totalValueProfited = 0.00;
                            double totalValueCost = 0.00;
                            double totalCostEmplyees = 0.00;

                            foreach(ProductionOrder ord in orders)
                            {

                                totalValueFatured += ord.Value;
                                totalValueProfited += ord.Profit();
                                totalValueCost += ord.Cost;

                            }

                            foreach(Employee emp in employees)
                            {

                                totalCostEmplyees = emp.Salary;

                            }

                            totalValueCost += totalCostEmplyees;

                            Console.WriteLine("Employee cost: R$" + totalCostEmplyees);
                            Console.WriteLine("Total cost: R$" + totalValueCost.ToString("F2", CultureInfo.InvariantCulture));
                            Console.WriteLine("-----------------");

                            Console.WriteLine("Total fatured: R$" + totalValueFatured.ToString("F2", CultureInfo.InvariantCulture));
                            Console.WriteLine("Total proft: R$" + totalValueProfited.ToString("F2", CultureInfo.InvariantCulture));

                            Console.Write("\nClick enter to continue. ");
                            Console.ReadLine();

                            Console.Clear();

                            break;

                        case 6:

                            Console.Clear();

                            Console.WriteLine("Orders registered:\n");

                            foreach (ProductionOrder prod in orders)
                            {

                                Console.WriteLine(prod.ToString());
                                Console.WriteLine("------------------------------------");

                            }

                            Console.Write("\nClick enter to continue. ");
                            Console.ReadLine();

                            Console.Clear();

                            break;

                        case 7:

                            Console.Clear();

                            Console.WriteLine("Products registered:\n");

                            foreach (Product p in products)
                            {

                                Console.WriteLine(p.ToString());
                                Console.WriteLine("------------------------------------");


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

}