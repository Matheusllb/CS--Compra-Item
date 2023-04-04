using System;
using System.Globalization;

namespace CsE11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCICIO 11
            Console.WriteLine("Compra de 1 item\n\nCODIGO      ESPECIFICACAO       PRECO\n");
            Console.WriteLine("1        Cachorro-Quente        R$ 4.00");
            Console.WriteLine("2        X-Salada               R$ 4.50");
            Console.WriteLine("3        X-Bacon                R$ 5.00");
            Console.WriteLine("4        Torrada simples        R$ 2.00");
            Console.WriteLine("5        Refrigerante           R$ 1.50");
            Console.WriteLine("\nOpcao:");
            int opc = int.Parse(Console.ReadLine());

            int quant;
            double total;

            if (opc == 1)
            {
                Console.WriteLine("\nCACHORRO-QUENTE SELECIONADO\nQuantidade: ");
                quant = int.Parse(Console.ReadLine());
                total = quant * 4.00;
                Console.WriteLine("\nTOTAL A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (opc == 2)
            {
                Console.WriteLine("\nX-SALADA SELECIONADO\nQuantidade: ");
                quant = int.Parse(Console.ReadLine());
                total = quant * 4.50;
                Console.WriteLine("\nTOTAL A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (opc == 3)
            {
                Console.WriteLine("\nX-BACON SELECIONADO\nQuantidade: ");
                quant = int.Parse(Console.ReadLine());
                total = quant * 5.00;
                Console.WriteLine("\nTOTAL A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (opc == 4)
            {
                Console.WriteLine("\nTORRADA SIMPLES SELECIONADO\nQuantidade: ");
                quant = int.Parse(Console.ReadLine());
                total = quant * 2.00;
                Console.WriteLine("\nTOTAL A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (opc == 5)
            {
                Console.WriteLine("\nREFRIGERANTE SELECIONADO\nQuantidade: ");
                quant = int.Parse(Console.ReadLine());
                total = quant * 1.50;
                Console.WriteLine("\nTOTAL A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else { Console.WriteLine("\nOpcao invalida!"); }
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
