using Internal;
using System;

class Desafio
{
    static void Main()
    {
        double[] notas = new double[2];
        int soma = 0;

        while (soma < 2)
        {
            double nota;
            if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
            {
                notas[soma] = nota;
                soma++;
            }
            else
            {
                Console.WriteLine("nota invalida");
            }
        }

        double media = (notas[0] + notas[1]) / 2.0;
        Console.Write("media = ");
        Console.WriteLine(media.ToString("N2"));

        while (true)
        {
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            int res;
            if (int.TryParse(Console.ReadLine(), out res))
            {
                if (res == 1)
                {
                    break;
                }
                else if (res == 2)
                {
                    return;
                }
            }
        }
    }
}
