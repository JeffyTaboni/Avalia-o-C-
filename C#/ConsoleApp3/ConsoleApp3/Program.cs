using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        private static void Calcular()
        {
            Console.WriteLine(Calcular(5));
        }

        private static int Calcular(int num)
        {
            if (num < 0)
                return -1;
            else if (num <= 1)
                return 1;

            return num -= num * Calcular(num - 1);
        }

        private static void GerarCaracteres()
        {
            Console.WriteLine(BuscarCaracteres());
        }

        private static string BuscarCaracteres()
        {
            const string conteudo = "0123,4567,8910,aaaA,Bccc";
            int[] lista = { 1, 2, 3, 4, 5 };
            int listaResultado = lista.Aggregate((a, b) => b + a);
            var novoConteudo = conteudo.Substring(listaResultado);
            novoConteudo = novoConteudo.Split(',')[1].Remove(2);

            return novoConteudo;
        }


        static void Main(string[] args)
        {
            Calcular();

            GerarCaracteres();
            
        }
    }
}
