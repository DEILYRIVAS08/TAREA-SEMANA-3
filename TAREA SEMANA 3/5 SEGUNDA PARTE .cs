using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese su zona: ");
            string Zona = Console.ReadLine();

            Console.WriteLine("Ingrese la calificación del examen final: ");
            string Calificacion = Console.ReadLine();

            if (int.TryParse(Zona, out int zona) && int.TryParse(Calificacion, out int calificacionFinal))
            {
                int Calificaciones = zona + calificacionFinal;

                if (zona >= 30 && zona <= 65)
                {
                    Console.WriteLine("¡FELICIDADES! Tienes derecho a examen final.");
                }
                else if (zona >= 0 && zona < 30)
                {
                    Console.WriteLine("Lo sentimos, no llegaste a la zona mínima.");
                }

                if (calificacionFinal >= 16 && calificacionFinal <= 35)
                {
                    Console.WriteLine("Desempeño en el examen final: SI SE ESFORZO");
                }
                else if (calificacionFinal >= 0 && calificacionFinal <= 15)
                {
                    Console.WriteLine("Desempeño en el examen final: NO SE ESFORZO");
                }

                if (Calificaciones >= 90 && Calificaciones <= 100)
                {
                    Console.WriteLine("Desempeño total: APROBADO, CON HONORES");
                }
                else if (Calificaciones >= 80 && Calificaciones <= 89)
                {
                    Console.WriteLine("Desempeño total: EXCELENTE");
                }
                else if (Calificaciones >= 70 && Calificaciones <= 79)
                {
                    Console.WriteLine("Desempeño total: MUY BUENO");
                }
                else if (Calificaciones >= 61 && Calificaciones <= 69)
                {
                    Console.WriteLine("Desempeño total: BUENO");
                }
                else if (Calificaciones >= 0 && Calificaciones <= 60)
                {
                    Console.WriteLine("Desempeño total: REPROBADO");
                }
                else
                {
                    Console.WriteLine("Suma de calificaciones no válida.");
                    return;
                }

                Console.WriteLine($"Desempeño total (zona + examen final): {Calificaciones}");
            }
            else
            {
                Console.WriteLine("Error: Ingrese calificaciones válidas (números enteros) para la zona y el examen final.");
            }
        }
        catch
        {
            Console.WriteLine($"Error inesperado:");
        }
    }
}


