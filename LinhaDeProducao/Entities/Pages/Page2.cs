using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao.Entities.Pages
{
    class Page2
    {

        public int Question()
        {

            int userMenuChoice = 0;
            bool isNumber;


            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine("11. Change order status.");

            Console.WriteLine("-------------------------------------");
            
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("0. Próxima página.");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\n-------------------------------------");


            Console.Write("Escolha a opção desejada: ");
            string userMenuChoiceString = Console.ReadLine();

            isNumber = int.TryParse(userMenuChoiceString, out userMenuChoice);


            if (isNumber)
            {

                userMenuChoice = int.Parse(userMenuChoiceString);

                Thread.Sleep(350);
                Console.Clear();

                return userMenuChoice;

            }
            else
            {

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

            Thread.Sleep(350);
            Console.Clear();

            return 0;

            }

        }

    }
}
