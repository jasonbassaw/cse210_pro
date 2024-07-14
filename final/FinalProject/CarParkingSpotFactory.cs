public class CarParkingSpotFactory : IParkingSpotFactory
{
    public ParkingSpot CreateParkingSpot(int spotNumber)
    {
        return new CarParkingSpot { SpotNumber = spotNumber, IsOccupied = false };
    }
}