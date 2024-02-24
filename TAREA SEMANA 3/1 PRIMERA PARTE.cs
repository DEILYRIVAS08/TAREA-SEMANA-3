using System;

class Program
{
    static void Main(string[] args)
    {

        int num1, num2, num3, numero;

        Console.WriteLine("Ingrese los 3 valores ");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());
        numero = num1;
        try
        {
            if (num2 > numero)
            {
                numero = num2;
            }

            if (num3 > numero)
            {
                numero = num3;
            }

            Console.WriteLine("El número mayor es: " + numero);
        }

        catch
        {
            Console.WriteLine("ERROR");
        }
    }
}
