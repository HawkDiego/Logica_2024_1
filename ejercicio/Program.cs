using System;

class Program
{
    static void Main(string[] args)
    {
        int number1, number2, number3;

        Console.Write("Ingresa el primer número: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el tercer número: ");
        number3 = Convert.ToInt32(Console.ReadLine());

        double exp=Math.Pow(number1, 2); 
        double sqr2 = Math.Sqrt(number2);      
        double sqr3 = Math.Pow(number3, 1.0 / 3.0);

        Console.WriteLine($"El cuadrado de {number1} es: {exp}");
        Console.WriteLine($"La raíz cuadrada de {number2} es: {sqr2}");
        Console.WriteLine($"La raíz cúbica de {number3} es: {sqr3}");
    }
}
