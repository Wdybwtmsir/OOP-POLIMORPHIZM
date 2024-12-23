using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ввод данных для спутниковой антенны:");
            Console.Write("Введите диаметр антенны: ");
            double diameter1 = double.Parse(Console.ReadLine());
            Console.Write("Введите материал антенны: ");
            string material1 = Console.ReadLine();
            Console.Write("Введите цену антенны: ");
            double price1 = double.Parse(Console.ReadLine());

            SatelliteDish dish1 = new SatelliteDish(diameter1, material1, price1);

            Console.WriteLine("\nВвод данных для расширенной спутниковой антенны:");
            Console.Write("Введите диаметр антенны: ");
            double diameter2 = double.Parse(Console.ReadLine());
            Console.Write("Введите материал антенны: ");
            string material2 = Console.ReadLine();
            Console.Write("Введите цену антенны: ");
            double price2 = double.Parse(Console.ReadLine());
            Console.Write("Введите тип подвески (азимутальный, полярный, тороидальный): ");
            string mountType = Console.ReadLine();

            AdvancedSatelliteDish dish2 = new AdvancedSatelliteDish(diameter2, material2, price2, mountType);

            Console.WriteLine("\nИнформация о спутниковой антенне:");
            dish1.PrintInfo();

            Console.WriteLine("\nИнформация о расширенной спутниковой антенне:");
            dish2.PrintInfo();
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода: Пожалуйста, введите корректные значения.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}