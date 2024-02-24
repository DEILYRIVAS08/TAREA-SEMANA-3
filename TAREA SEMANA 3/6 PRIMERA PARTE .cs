using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("INGRESE EL MONTO DEL PRESTAMO:");
            double Prestamo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su edad:");
            int edadU = Convert.ToInt32(Console.ReadLine());

            if (Prestamo < 5000 || edadU > 60)
            {
                Console.WriteLine("Préstamo Aprobado ");
            }
            else
            {
                Console.WriteLine("Préstamo Rechazado");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un formato válido para MONTO o EDAD.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El valor ingresado es demasiado grande o pequeño.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: ");
        }
    }
}
