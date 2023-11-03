using System.Data;
using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoContatos
{
    public class GerenciamentoContatos
    {
        public static void Main(string[] args)
        {
            while (true)
            {

                string nome = Console.ReadLine();


                string email = Console.ReadLine();


                string telefone = Console.ReadLine();


                var contato = new Contato(nome, email, telefone);


                contato.MostarInformacoes();
                break;
            }
        }

        public class Contato()
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }

            public Contato(string nome, string email, string telefone)
            {
                Nome = nome;
                Email = email;
                Telefone = telefone;
                Console.WriteLine("Contato adicionado!");
            }
            public void MostrarInformacoes()
            {
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("E-mail: " + Email);
                Console.WriteLine("Tel: " + Telefone);
            }
        }
    }
}