using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese un número del 1 al 7 para representar un día de la semana: ");
        int numDia = Convert.ToInt32(Console.ReadLine());

        string nomDia;

        switch (numDia)
        {
            case 1:
                nomDia = "Lunes";
                break;

            case 2:
                nomDia = "Martes";
                break;

            case 3:
                nomDia = "Miércoles";
                break;

            case 4:
                nomDia = "Jueves";
                break;

            case 5:
                nomDia = "Viernes";
                break;

            case 6:
                nomDia = "Sábado";
                break;

            case 7:
                nomDia = "Domingo";
                break;

            default:
                Console.WriteLine("Número de día no válido.");
                return;
        }

        Console.WriteLine($"El día de la semana es: {nomDia}");

    }
}
