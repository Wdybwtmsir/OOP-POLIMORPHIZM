using System;

public class AdvancedSatelliteDish : SatelliteDish
{
    public string MountType { get; set; }

    public AdvancedSatelliteDish(double diameter, string material, double price, string mountType)
        : base(diameter, material, price)
    {
        MountType = mountType;
    }

    public override double CalculateQuality()
    {
        double baseQuality = base.CalculateQuality();
        switch (MountType.ToLower())
        {
            case "азимутальный":
                return baseQuality;
            case "полярный":
                return 2 * baseQuality;
            case "тороидальный":
                return 2.5 * baseQuality;
            default:
                throw new ArgumentException("Неизвестный тип подвески.");
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Расширенная спутниковая антенна: Диаметр - {Diameter}, Материал - {Material}, Цена - {Price}, Тип подвески - {MountType}, Качество (Qp) - {CalculateQuality()}");
    }
}