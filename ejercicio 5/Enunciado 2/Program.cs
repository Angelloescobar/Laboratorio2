using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número del 1 al 7: ");
        int numero = int.Parse(Console.ReadLine());
        string dia = ObtenerDiaDeLaSemana(numero);
        Console.WriteLine($"Día de la semana: {dia}");
    }

    static string ObtenerDiaDeLaSemana(int numero)
    {
        switch (numero)
        {
            case 1:
                return "Lunes";
            case 2:
                return "Martes";
            case 3:
                return "Miércoles";
            case 4:
                return "Jueves";
            case 5:
                return "Viernes";
            case 6:
                return "Sábado";
            case 7:
                return "Domingo";
            default:
                return "Número inválido";
        }
    }
}
