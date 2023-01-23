using LinhaDeProducao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao.Entities
{
    class ProductionOrder
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Product { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime PreviousDate { get; set; }
        public DateTime RealDate { get; set; }
        public string Employee { get; set; }
        public ProductionStatus Status { get; set; }
        public double Cost { get; set; }
        public double Value { get; set; }

        public ProductionOrder
            (
            int id, 
            string name, 
            int product, 
            DateTime initialDate, 
            DateTime previousDate, 
            DateTime realDate, 
            string employee, 
            ProductionStatus status, 
            double cost, 
            double value
            )
        {
            Id = id;
            Name = name;
            Product = product;
            InitialDate = initialDate;
            PreviousDate = previousDate;
            RealDate = realDate;
            Employee = employee;
            Status = status;
            Cost = cost;
            Value = value;
        }

        public double Profit()
        {

            return Value - Cost;

        }


        public override string ToString()
        {
            return "Id: " + Id + 
                    "\nName: " + Name +
                    "\nProduct: " + Product +
                    "\nInitial Date: " + InitialDate +
                    "\nPrevious Date: " + PreviousDate +
                    "\nReal Date: " + RealDate +
                    "\nEmploye: " + Employee +
                    "\nStatus: " + Status +
                    "\nCost: R$" + Cost +
                    "\nValue: R$" + Value + 
                    "\nProfit: R$" + Profit().ToString();

        }
    }
}
