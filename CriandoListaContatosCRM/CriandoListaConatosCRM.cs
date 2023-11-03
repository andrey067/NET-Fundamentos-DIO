using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriandoListaContatosCRM
{
    public static void Main(string[] args)
    {
        int tamanhoLista = int.Parse(Console.ReadLine());

        List<string> listaClientes = new List<string>();

        for (int i = 0; i <= tamanhoLista; i++)
        {
            string nomeCliente = Console.ReadLine();
            listaClientes.Add(nomeCliente);
        }

        Console.WriteLine("Lista de Contatos:");

        int contador = 1;
        foreach (string cliente in listaClientes)
        {
            Console.WriteLine(contador + ". " + listaClientes[contador - 1]);
            contador++;
        }
    }
}