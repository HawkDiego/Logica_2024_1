

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa tu salario base: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor venta 1: ");
        double sell1 = Convert.ToDouble(Console.ReadLine());
        double commission1 = sell1 * 0.1;
        Console.Write("Valor venta 2: ");
        double sell2 = Convert.ToDouble(Console.ReadLine());
        double commission2 = sell2 * 0.1;
        Console.Write("Valor venta 3: ");
        double sell3 = Convert.ToDouble(Console.ReadLine());
        double commission3 = sell3 * 0.1;

        double totalCommission = commission1 + commission2 + commission3;

        double totalSells = sell1 + sell2 + sell3;

        double salaryMoreCommissions = totalCommission + salary;

        double maxSell = Math.Max(sell1, Math.Max(sell2, sell3));

        double averageCommission = totalCommission / 3;

        Console.WriteLine($"Dinero por concepto de comisiones: {totalCommission}");
        Console.WriteLine($"Comisiones mas salario base: {salaryMoreCommissions}");
        Console.WriteLine($"Venta que generó mas comision: {maxSell}");
        Console.WriteLine($"Promedio de comisiones: {averageCommission}");

        if (totalSells >= 1000000) Console.WriteLine("Ganaste el beneficio");
        else Console.WriteLine("No ganaste el beneficio");

    }
}
