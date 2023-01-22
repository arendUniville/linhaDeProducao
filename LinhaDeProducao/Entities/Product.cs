using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            return "Profit: " + profit.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
