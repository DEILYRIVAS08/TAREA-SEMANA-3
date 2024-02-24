using System;

class Program
{
    static void Main(string[] args)
    {


        try
        {
            Console.WriteLine("INGRESE SU EDAD");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad ,BIENVENIDO AL CLUB");
            }
            else
            {
                Console.WriteLine("LO SENTIMOS NO PUEDES INGRESAR AL CLUB, eres menor de edad");
            }
        }
        catch
        {
            Console.WriteLine("Error en el programa");

        }


    }
}

