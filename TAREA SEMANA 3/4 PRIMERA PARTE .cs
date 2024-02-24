using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Ingrese el nombre de usuario: ");
            string Usuario = Console.ReadLine();

            Console.Write("Ingrese la contraseña: ");
            string contraseña = Console.ReadLine();


            if (VerificarCredenciales(Usuario, contraseña))
            {
                Console.WriteLine("Acceso concedido. ¡Bienvenido!");
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas. Acceso denegado.");
            }
        }
        catch
        {

            Console.ReadLine();
        }

        static bool VerificarCredenciales(string usuario, string contraseña)
        {

            return usuario.ToLower() == "usuario" && contraseña == "contraseña";
        }
    }
}


