using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el tipo de servicio: ");
        Console.WriteLine("1 \"lavado de auto\", 2 \"cambio de aceite\", 3 \"revisión mecánica\": ");
        string Servicio = Console.ReadLine().ToLower();

        double importe = 0.0;

        switch (Servicio)
        {
            case "1":
                importe = 20.0;
                break;

            case "2":
                importe = 50.0;
                break;

            case "3":
                importe = 80.0;
                break;

            default:
                Console.WriteLine("Tipo de servicio no reconocido.");
                return;
        }

        Console.WriteLine($"El importe a pagar por {Servicio} es: Q{importe}");


    }
}
