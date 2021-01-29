using System;
using System.Collections.Generic;
using System.Linq;


namespace WmsNumbers
{

    class Program
    {
        internal class Numbers
        {
            private readonly List<int> _listNumbers;

            public Numbers()
            {
                _listNumbers = new List<int>();

            }

            public void AddValue(int value)
            {
                _listNumbers.Add(value);
            }

            public int Calculate()
            {
                var numbers = _listNumbers.Where(x => x >= 10 - x);
                var values = _listNumbers.Where(y => y < 15 - y);
                return values.Sum(x => x);

            }

        }

        public class Numeros
        {
            public static void GerarNumero()
            {
                var numbers = new Numbers();
                numbers.AddValue(2);
                numbers.AddValue(3);
                numbers.AddValue(9);
                Console.WriteLine(Convert.ToString(numbers.Calculate()));
            }

        }

        static void Main()
        {

            Numeros.GerarNumero();
            
        }


    }
}
