using System;

class Program
{
    static void Main()
    {
        string correctUsername = "angello";
        string correctPassword = "10";

        Console.Write("Ingrese su nombre de usuario: ");
        string username = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string password = Console.ReadLine();

        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("Acceso concedido");
        }
        else if (username == correctUsername)
        {
            Console.WriteLine("Contraseña incorrecta");
        }
        else
        {
            Console.WriteLine("Usuario no registrado");
        }
    }
}
