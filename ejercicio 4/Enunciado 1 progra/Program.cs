using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());
        string categoria = ClasificarEdad(edad);
        Console.WriteLine($"Categoría: {categoria}");
    }

    static string ClasificarEdad(int edad)
    {
        if (edad < 12)
        {
            return "Niño";
        }
        else if (edad >= 12 && edad <= 17)
        {
            return "Adolescente";
        }
        else if (edad >= 18 && edad <= 59)
        {
            return "Adulto";
        }
        else
        {
            return "Adulto mayor";
        }
    }
}

