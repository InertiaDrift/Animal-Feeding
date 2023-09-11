public abstract class Animal //parent class
{
    public abstract double GetFoodConsumption(double time);

    public double GetTotalFoodConsumption(double time, int count)
    {
        return count * GetFoodConsumption(time);
    }
}

public sealed class Squirrel : Animal  //derived class from animals
                                       //class is sealed so it cannot be used for any other class
{
    private const double FoodConsumptionRate = 1.0 / 90.0;

    public override double GetFoodConsumption(double time) //foodconsumption method that wasn't defined in parent class
    {
        return FoodConsumptionRate * time;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int squirrelCount = 9; //setting count value
        double totalTime = 9 * 60.0; // in seconds
        Animal animal = new Squirrel();
        double totalFood = animal.GetTotalFoodConsumption(totalTime, squirrelCount);
        Console.WriteLine("Total food consumed: {0} nuts", totalFood);
    }
}


//code can be used for any animal with some minor changes



public class TestAnimal
{
    public static void Main()
    {
        // Create a new Squirrel object
        Animal animal = new Squirrel();

        // Test GetFoodConsumption method
        double foodConsumption = animal.GetFoodConsumption(60.0);
        Console.WriteLine("Food consumed by one squirrel in one minute: {0} nuts", foodConsumption);

        // Test GetTotalFoodConsumption method
        int squirrelCount = 9;
        double totalTime = 9 * 60.0; // in seconds
        double totalFood = animal.GetTotalFoodConsumption(totalTime, squirrelCount);
        Console.WriteLine("Total food consumed by {0} squirrels in {1} minutes: {2} nuts", squirrelCount, totalTime / 60.0, totalFood);
    }
}
