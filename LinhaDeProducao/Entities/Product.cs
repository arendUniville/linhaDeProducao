using System;
using System.Globalization;

namespace LinhaDeProducao.Entities
{
    class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public double EntryValue { get; set; }
        public double OutValue { get; set; }
        public string SerialId { get; set; }


        public Product() { }

        public Product(int id, string name, int amount, double entryValue, double outValue, string serialId)
        {

            Id = id;
            Name = name;
            Amount = amount;
            EntryValue = entryValue;
            OutValue = outValue;
            SerialId = serialId;

        }


        public string Profit()
        {

            double profit = OutValue - EntryValue;

            return profit.ToString("F2", CultureInfo.InvariantCulture);

        }

        public double StockValue()
        {

            return OutValue * Amount;

        }

        public override string ToString()
        {
            return "Id: " + Id + 
                    "\nName: " + Name + 
                    "\nAmount " + Amount + 
                    "\nProfit: R$" + Profit() + 
                    "\nOutValue: R$" + OutValue.ToString("F2", CultureInfo.InvariantCulture) +
                    "\n---------------------------" +
                    "\nStock Product Value: R$" + StockValue().ToString("F2", CultureInfo.InvariantCulture) + ".";
        }
    }
}
