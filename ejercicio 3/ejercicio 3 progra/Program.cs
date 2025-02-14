using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"¿{num1} es mayor que {num2}? {num1 > num2}");
        Console.WriteLine($"¿{num1} es menor que {num2}? {num1 < num2}");
        Console.WriteLine($"¿{num1} es igual a {num2}? {num1 == num2}");

        Console.WriteLine($"¿{num1} es mayor que {num2} y {num1} es igual a {num2}? {num1 > num2 && num1 == num2}");
        Console.WriteLine($"¿{num1} es mayor que {num2} o {num1} es igual a {num2}? {num1 > num2 || num1 == num2}");
    }
}
