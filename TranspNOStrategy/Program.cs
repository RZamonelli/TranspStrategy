using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranspNOStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distância: ");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o tipo de frete (1) Normal, (2) Sedex: ");
            int freightOption = Convert.ToInt32(Console.ReadLine());

            FreightOption typeFreight = (FreightOption)freightOption -1;
         
            Freight freight = new Freight(typeFreight);

            double price = freight.CalcPrice(distance);
            Console.WriteLine("O valor total é de ");
            Console.WriteLine(price);            

            Console.ReadKey();
        }
    }

    public class Freight
    {
        private FreightOption type;

        public Freight(FreightOption type)
        {
            this.type = type;
        }

        public double CalcPrice(int distance)
        {
            double price = 0;
            if (FreightOption.NORMAL.Equals(type))
            {
                price = distance * 1.25 + 10;
            }
            else if (FreightOption.SEDEX.Equals(type))
            {
                price = distance * 1.45 + 12;
            }

            return price;
        }
    }

    public enum FreightOption
    {
        NORMAL,
        SEDEX
    }
}
