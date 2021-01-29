using System;
using System.Collections.Generic;
using System.Linq;

namespace WmsNumbers
{
    delegate int NumberChanger(int n);

    public class Valor
    {
        private static int num = 10;
        private static int AddNum(int p)
        {
            num += p;
            return num;
        }

        private static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int GetValue()
        {
            NumberChanger nc;
            var nc1 = new NumberChanger(AddNum);
            var nc2 = new NumberChanger(MultNum);
            nc = nc1;
            nc += nc2;
            nc(5);
            return num;
        }

        public static void GerarValor()
        {
            System.Console.WriteLine(GetValue());
        }

        static void Main()
        {

            GerarValor();

        }

    }

    
}

