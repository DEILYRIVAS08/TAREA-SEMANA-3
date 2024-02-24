using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese un número del 1 al 5 en letra (\"uno\", \"dos\", \"tres\", \"cuatro\", \"cinco\"): ");
        string nLetra = Console.ReadLine().ToLower();

        int nDigito;

        switch (nLetra)
        {
            case "uno":
                nDigito = 1;
                break;

            case "dos":
                nDigito = 2;
                break;

            case "tres":
                nDigito = 3;
                break;

            case "cuatro":
                nDigito = 4;
                break;

            case "cinco":
                nDigito = 5;
                break;

            default:
                Console.WriteLine("Número no reconocido.");
                return;
        }

        Console.WriteLine($"El número en dígito es: {nDigito}");

    }

}

