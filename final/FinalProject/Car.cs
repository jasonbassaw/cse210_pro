public class Car : Vehicle
{
    public override void Park()
    {
        Console.WriteLine($"Car with license plate {LicensePlate} is parked.");
    }
}