using System;

public class AdvancedSatelliteDish : SatelliteDish
{
    private string suspensionType;

    public AdvancedSatelliteDish(double diameter, string material, double price, string suspensionType)
        : base(diameter, material, price)
    {
        this.suspensionType = suspensionType;
    }
    public new double CalculateQuality()
    {
        double q = base.CalculateQuality();

        switch (suspensionType.ToLower())
        {
            case "азимутальная":
                return q;
            case "полярная":
                return 2 * q;
            case "тороидальная":
                return 2.5 * q;
            default:
                throw new ArgumentException("Неизвестный тип подвески");
        }
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип подвески: {suspensionType} | Qp: {CalculateQuality()}");
    }
}