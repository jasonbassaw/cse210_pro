public class CarParkingSpot : ParkingSpot
{
    public override void AssignVehicle(Vehicle vehicle)
    {
        if (!IsOccupied)
        {
            Console.WriteLine($"Car with license plate {vehicle.LicensePlate} is assigned to spot {SpotNumber}.");
            IsOccupied = true;
            vehicle.Park();
        }
        else
        {
            Console.WriteLine($"Spot {SpotNumber} is already occupied.");
        }
    }
}