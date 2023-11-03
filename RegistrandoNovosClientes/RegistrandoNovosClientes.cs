using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrandoNovosClientes
{
    public class RegistrandoNovosClientes
    {
        public static void Main(string[] args)
        {
            List<Clientes> clientes = new List<Clientes>();

            while (true)
            {
                string nome = Console.ReadLine();
                string email = Console.ReadLine();
                string telefone = Console.ReadLine();

                string clienteInfo = new Clientes(nome, email, telefone)
                clientes.Add(clienteInfo);

                string continuar = Console.ReadLine();

                if (continuar != "S")
                {
                    foreach (var cliente in clientes)
                    {
                        cliente.MostrarCliente();
                    }
                    break;
                }
            }
        }

        public class Clientes()
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }

            public Clientes(string nome, string email, string telefone)
            {
                Nome = nome;
                Email = email;
                Telefone = telefone;
            }

            public void MostrarCliente()
            {
                Console.WriteLine($"{Nome}, {Email}, {Telefone}");               
            }
        }
    }
}