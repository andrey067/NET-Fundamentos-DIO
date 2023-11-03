using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificaoClientes
{
    public class ClassficacaoClientes
    {
        public static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double valorTotalCompras = double.Parse(Console.ReadLine());

            string categoria;

            if (valorTotalCompras >= 500)
            {
                categoria = "CLIENTE";
            }
            else
            {
                categoria = "LEAD";
            }

            Console.WriteLine($"{nome} foi classificado(a) como {categoria}");

        }
    }
}