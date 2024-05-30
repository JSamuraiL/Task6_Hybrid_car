// See https://aka.ms/new-console-template for more information

using static Task6.HybridCar;
using Task6;

HybridCar car = new HybridCar(DriveMode.Electric);

Console.WriteLine($"Режим: {car.Mode}, Расход топлива: {car.GetFuelConsumption()} л/км");

car.SetDriveMode(DriveMode.Gasoline, 0.05); // допустим, расход будет 0.05 л/км
Console.WriteLine($"Режим: {car.Mode}, Расход топлива: {car.GetFuelConsumption()} л/км");