using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NumeroExtenso;
using System.Globalization;

namespace TesteExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double numDouble = 0;
            Int64 numInt = 0;
            decimal numDecimal = 0;
            do
            {
                string valor = Console.ReadLine();
                numDouble = double.Parse(valor);
                numInt = (int)numDouble;
                numDecimal = decimal.Parse(valor);

                //num = Decimal.Parse(valor, CultureInfo.InvariantCulture);
                Console.WriteLine(numDouble.ToLongString());
                //Console.WriteLine(numInt.ToLongString());
                //Console.WriteLine(numDecimal.ToLongString());
            }
            while (numDouble != 0);
        }
    }
}
