using System;
using System.Security.Cryptography;
using LinhaDeProducao.Entities;
using System.Globalization;
using LinhaDeProducao.Entities.Enums;
using LinhaDeProducao.Entities.Pages;
using System.Xml.Linq;

namespace LinhaDeProducao
{

    class Program
    {

        static void Main(string[] args) 
        {

            Console.WriteLine("Bem vindo ao sistema de linha de produção.\n");

            bool userWantContinue = true;
            
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
                int userMenuChoice;

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

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("10. Próxima página.");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("\n-------------------------------------");



                Console.Write("Escolha a opção desejada: ");
                string userMenuChoiceString = Console.ReadLine();

                isNumber = int.TryParse(userMenuChoiceString, out userMenuChoice);

                if (isNumber)
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

                    if(userMenuChoice == 0)
                    {

                        Page2 page2 = new Page2();

                        userMenuChoice = page2.Question();

                        Console.WriteLine("Fora: "+userMenuChoice);
                    }

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


                            int employeesAdded = 0;

                            for (int i = 0; i < quantityEmployeeAdd; i++)
                            {

                                if(i > 0)
                                {

                                    int z = i - 1;

                                    Console.Clear();

                                    Console.Write("Employees added:\n");

                                    for(; z < employeesAdded; z++)
                                    {

                                        Console.WriteLine("\n"+employees[z]+"\n");

                                        if(employeesAdded > 1)
                                        {

                                            Console.WriteLine("\n-------------------");

                                        }

                                    }


                                }

                                employeeId += 1;

                                Console.WriteLine("==========================\n");

                                Console.Write("\nDigite o nome do employee: ");
                                employeeName = Console.ReadLine();

                                Console.Write("Insira a data de nascimento: ");
                                employeeBorn = DateTime.Parse(Console.ReadLine());

                                Console.Write("Entry salary employee: R$ ");
                                employeeSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                employees.Add(new Employee(employeeId, employeeName, employeeBorn, employeeSalary, EmployeePosition.Auxiliary));

                                employeesAdded += 1;


                                if (employeesAdded == quantityEmployeeAdd)
                                {

                                    int z = i - 1;

                                    Console.Clear();

                                    Console.Write("Employees added:\n");

                                    for (; z < employeesAdded; z++)
                                    {

                                        Console.WriteLine("\n" + employees[z] + "\n");

                                        if (employeesAdded > 1)
                                        {

                                            Console.WriteLine("-------------------");

                                        }

                                    }

                                }

                            }

                            Console.Write("\nClick enter to continue. ");
                            Console.ReadLine();

                            Console.Clear();

                            break;

                        case 3:

                            Console.WriteLine("NEW ORDER\n");

                            int quantityProductionOrderAdd = 0;

                            Console.Write("How many orders do you want to add? Quantity: ");
                            quantityProductionOrderAdd = int.Parse(Console.ReadLine());

                            for (int i = 0; i < quantityProductionOrderAdd; i++)
                            {

                                productionId += 1;

                                Console.Write("Entry name production: ");
                                productionName = Console.ReadLine();

                                Console.Write("Entry id product: ");
                                productionProductName = int.Parse(Console.ReadLine());

                                productionInitDate = DateTime.Now;

                                Console.Write("Entry Previous Date: ");
                                productionPreviousDate = DateTime.Parse(Console.ReadLine());

                                productionRealDate = productionPreviousDate;

                                Console.Write("Entry id employe responsible: ");
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

                                Console.Write("Cost: R$");
                                productionCost = double.Parse(Console.ReadLine());

                                Console.Write("Value: R$");
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

                            Console.WriteLine("Orders registered:\n");

                            foreach (ProductionOrder prod in orders)
                            {

                                Console.WriteLine(prod.Id + " | Title: " + prod.Name + " | Product: " + prod.Product + " | Started At: " + prod.InitialDate + " | Value: R$" + prod.Value);
                                Console.WriteLine("------------------------------------");

                            }


                            Console.Write("Entry order Id to remove an order: ");

                            int orderIdToDelete = int.Parse(Console.ReadLine());

                            orders.RemoveAt(orderIdToDelete);

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

                            double stockValue = 0.00;
                            double stockProductValue = 0.00;

                            foreach (Product p in products)
                            {

                                Console.WriteLine(p.ToString());
                                Console.WriteLine("------------------------------------");

                                stockValue += p.StockValue();

                            }

                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Stock Value: R$"+stockValue.ToString("F2", CultureInfo.InvariantCulture));
                            Console.WriteLine("------------------------------------");

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

                            
                        case 10:

                            return;

                        case 11:

                            Console.Write("Entry order Id to change status.");
                            Console.ReadLine();


                            Console.Write("\nClick enter to continue. ");
                            Console.ReadLine();

                            Console.Clear();

                            break;

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