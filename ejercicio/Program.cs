

class Program
{
    static void Main(string[] args)
    {
        double trainSpeed1 = 80;
        double trainSpeed2 = 100;

        double initialTime = 1;

        double distanceBetweenTrains = trainSpeed1* initialTime;

        double timeToCatchUp = distanceBetweenTrains / (trainSpeed2 - trainSpeed1);

        double catchUpTime = timeToCatchUp + 10;
   
        Console.WriteLine($"El segundo tren alcanzará al primer tren a las {catchUpTime}");
    }
}
