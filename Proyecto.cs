using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_de_prestamos
{
    class Program
    {
        static void Main(string[] args)
        {

            float pago, Interes, Capital, MontoPrestamo, TasaAnual, TasaMensual;
            int  fila, Plazo, i;

            Console.WriteLine("Monto del prestamo: ");
            float.TryParse(Console.ReadLine(), out  MontoPrestamo);
            Console.WriteLine("Interes anual: ");
            float.TryParse(Console.ReadLine(), out  TasaAnual);
            Console.WriteLine("Plazo de pago (Meses): ");
            int.TryParse(Console.ReadLine(), out  Plazo);

            //Calculo del interes mensual
            TasaMensual = (TasaAnual / 100) / 12;


            //Calculo de la cuota mensual
            pago = TasaMensual + 1;
            pago = (float)Math.Pow(pago, Plazo);
            pago = pago - 1;
            pago = TasaMensual / pago;
            pago = TasaMensual + pago;
            pago = MontoPrestamo * pago;



           
            Console.WriteLine();
            fila = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Numero de pago \t");
            Console.Write("Pago \t\t");
            Console.Write("Intereses Pagados \t\t");
            Console.Write("Capital Pagado \t\t");
            Console.Write("Monto del prestamo \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", MontoPrestamo);


            for (i = 1; i <= Plazo; i++)
            {

             
                Console.Write("\t{0}\t\t", fila);

               
                Console.Write("{0}\t",pago);

               
                Interes = TasaMensual * MontoPrestamo;
                Console.Write("{0}\t\t",Interes);

               
                Capital = pago - Interes;
                Console.Write("\t{0}\t",Capital);

               
                MontoPrestamo = MontoPrestamo - Capital;
                Console.Write("\t{0}\t",MontoPrestamo);

                fila = fila + 1;
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}