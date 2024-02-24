using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Ingresa el precio original del producto : Q ");
            double pOriginal = Convert.ToDouble(Console.ReadLine());

            if (pOriginal >= 100.0)
            {

                double descuento = pOriginal * 0.1;

                double pFinal = pOriginal - descuento;


                Console.WriteLine($"Precio original: Q{pOriginal}");
                Console.WriteLine($"Descuento del 10%: Q{descuento}");
                Console.WriteLine($"Precio final : Q{pFinal}");
            }
            else
            {

                Console.WriteLine("Nopuedes obtener el descuento.");
                Console.WriteLine($"Precio original: Q{pOriginal}");
            }
        }
        catch
        {


            Console.ReadLine();
        }
    }
}


