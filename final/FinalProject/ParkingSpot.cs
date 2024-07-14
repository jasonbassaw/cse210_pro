public abstract class ParkingSpot
{
    public int SpotNumber { get; set; }
    public bool IsOccupied { get; set; }
    public abstract void AssignVehicle(Vehicle vehicle);
}
