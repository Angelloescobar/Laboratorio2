using System;

class Program
{
    static void Main()
    {
        // Parte 2: Operaciones Matemáticas

        // Operaciones con int
        RealizarOperaciones<int>("int");

        // Operaciones con float
        RealizarOperaciones<float>("float");

        // Operaciones con decimal
        RealizarOperaciones<decimal>("decimal");

        // Operaciones con short
        RealizarOperaciones<short>("short");

        // Operaciones con byte
        RealizarOperaciones<byte>("byte");
    }

    static void RealizarOperaciones<T>(string tipo) where T : struct, IConvertible
    {
        Console.WriteLine($"Ingrese el primer número ({tipo}):");
        T num1 = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

        Console.WriteLine($"Ingrese el segundo número ({tipo}):");
        T num2 = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

        dynamic a = num1;
        dynamic b = num2;

        Console.WriteLine($"Suma ({tipo}): {a} + {b} = {a + b}");
        Console.WriteLine($"Resta ({tipo}): {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplicación ({tipo}): {a} * {b} = {a * b}");
        Console.WriteLine($"División ({tipo}): {a} / {b} = {(b != 0 ? (a / b).ToString() : "Indefinido")}");
    }
}
