using System;

public class Program
{
    public static void Main(string[] args)
    {
        SatelliteDish dish = new SatelliteDish(1.5, "металл", 200);
        dish.DisplayInfo();

        AdvancedSatelliteDish advancedDish = new AdvancedSatelliteDish(1.8, "пластик", 250, "полярная");
        advancedDish.DisplayInfo();

        Console.ReadKey();
    }
}