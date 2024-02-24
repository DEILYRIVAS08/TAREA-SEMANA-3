using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ingrese el idioma de su preferencia (\"español\", \"inglés\", \"francés\"): ");
        string idioma = Console.ReadLine().ToLower();
        string Mensaje = "";

        switch (idioma)
        {
            case "español":
                Mensaje = "¡Bienvenido!";
                break;

            case "inglés":
                Mensaje = "Welcome!";
                break;

            case "francés":
                Mensaje = "Bienvenue!";
                break;

            default:
                Console.WriteLine("Idioma no reconocido.");
                return;
        }

        Console.WriteLine(Mensaje);
    }
}
