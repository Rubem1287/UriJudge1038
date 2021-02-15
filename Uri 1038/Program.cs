using System;
using System.Globalization;
namespace Uri_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valor, total,produto1, produto2, produto3, produto4,produto5;
            valor = 0;

            produto1 = 4.00;
            produto2 = 4.50;
            produto3 = 5.00;
            produto4 = 2.00;
            produto5 = 1.50;

            string[] vetor = Console.ReadLine().Split(' ');
            codigo = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1]);

            if(codigo == 1)
            {
                valor = quantidade * produto1;
            }
            else if(codigo == 2)
            {
                valor = quantidade * produto2;
            }
            else if (codigo == 3)
            {
                valor = quantidade * produto3;
            }
            else if (codigo == 4)
            {
                valor = quantidade * produto4;
            }
            else if (codigo == 5)
            {
                valor = quantidade * produto5;
            }

            Console.WriteLine("Total : R$ "+valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
