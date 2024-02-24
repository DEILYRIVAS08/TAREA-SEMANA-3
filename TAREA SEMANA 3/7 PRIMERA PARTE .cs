using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese el tipo de figura geométrica:");
            Console.WriteLine(
        " 1 triángulo" +
        " 2 cuadrado " +
        " 3 círculo):");
            string Figura = Console.ReadLine().ToLower();
            double area = 0.0;

            switch (Figura)
            {
                case "1":
                    Console.WriteLine("Ingrese la base del triángulo:");
                    double baseT = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura del triángulo:");
                    double alturaT = Convert.ToDouble(Console.ReadLine());

                    area = 0.5 * baseT * alturaT;
                    break;

                case "2":
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double ladoC = Convert.ToDouble(Console.ReadLine());

                    area = ladoC * ladoC;
                    break;

                case "3":
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radioC = Convert.ToDouble(Console.ReadLine());

                    area = Math.PI * Math.Pow(radioC, 2);
                    break;

                default:
                    Console.WriteLine("Tipo de figura no VALIDO.");
                    return;
            }

            Console.WriteLine($"El área de la figura geométrica es: {area}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un formato válido para las dimensiones.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El valor ingresado es demasiado grande o pequeño.");
        }
        catch
        {
            Console.WriteLine($"Error inesperado: ");
        }
    }
}

