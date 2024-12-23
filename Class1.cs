using System;

public class SatelliteDish
{
    public double Diameter { get; set; }
    public string Material { get; set; }
    public double Price { get; set; }

    public SatelliteDish(double diameter, string material, double price)
    {
        Diameter = diameter;
        Material = material;
        Price = price;
    }

    public double CalculateQuality()
    {
        if (Price <= 0)
        {
            throw new ArgumentException("Цена должна быть больше нуля.");
        }
        return Diameter / Price;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Спутниковая антенна: Диаметр - {Diameter}, Материал - {Material}, Цена - {Price}, Качество (Q) - {CalculateQuality()}");
    }
}