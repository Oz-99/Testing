using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! criatura mágica!");

        var calc = new Calculadora();
        var suma = calc.Sumar(3, 4);
        var resta = calc.Restar(10, 5);
        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"La resta es: {resta}");
    }
}
