using System;

public class SatelliteDish
{
    
    private double diameter; 
    private string material; 
    private double price;     

    public SatelliteDish(double diameter, string material, double price)
    {
        this.diameter = diameter;
        this.material = material;
        this.price = price;
    }

    public double CalculateQuality()
    {
        return diameter / price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Диаметр: {diameter} | Материал: {material} | Цена: {price} | Q: {CalculateQuality()}");
    }
}