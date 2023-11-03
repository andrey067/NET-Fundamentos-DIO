using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerificarIdade
{
    public class VerificacaoIdade
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Seja bem-vindo!");
                Console.WriteLine("Acesso permitido ao CRM.");
            }
            else
            {
                Console.WriteLine("Você não tem acesso permitido.");
            }
        }
    }
}