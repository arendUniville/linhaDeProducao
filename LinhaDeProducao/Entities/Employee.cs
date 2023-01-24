using LinhaDeProducao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao.Entities
{
    class Employee
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public DateTime Born { get; set; }
        public double Salary { get; protected set; }
        public EmployeePosition Position { get; set; }


        public Employee() { }

        public Employee(int id, string firstName, DateTime born, double salary, EmployeePosition position)
        {
            Id = id;
            FirstName = firstName;
            Born = born;
            Salary = salary;
            Position = position;
        }


        public override string ToString()
        {
            return "Id: " + Id + 
                    "\nName: " + FirstName + 
                    "\nBorn: " + Born.ToString("dd/MM/yyyy") + 
                    "\nSalary: R$" + Salary.ToString("F2", CultureInfo.InvariantCulture) + 
                    "\nPosition:" + Position.ToString();
        }
    }
}
