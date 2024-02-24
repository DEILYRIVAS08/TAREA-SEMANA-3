using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Ingrese un número: ");
            int nume = Convert.ToInt32(Console.ReadLine());


            if (espar(nume))
            {
                Console.WriteLine($"El número {nume} es par.");
            }
            else
            {
                Console.WriteLine($"El número {nume} es impar.");
            }
        }
        catch
        {

            Console.ReadLine();
        }


        static bool espar(int num)
        {

            return num % 2 == 0;
        }
    }
}

