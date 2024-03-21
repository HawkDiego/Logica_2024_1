using System;

class Program
{
    static void Main(string[] args)
    {
        string repeat;
        do
        {
            Console.Write("Ingrese el weight del paciente en kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la height del paciente en metros: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double imc = weight / Math.Pow(height, 2);
            string category;

            if (imc < 18.5)
                category = "peso insuficiente";
            else if (imc >= 18.5 && imc <= 24.9)
                category=  "weight saludable";
            else if (imc >= 25 && imc <= 29.9)
                category=  "Sobreweight";
            else
                category = "Obesidad";


            Console.WriteLine("La categoría del IMC del paciente es: " + category);

            Console.Write("¿Desea calcular el IMC de otro paciente? (s/n): ");
            repeat = Console.ReadLine();
        }
        while (repeat.ToLower() == "s");
    }
}