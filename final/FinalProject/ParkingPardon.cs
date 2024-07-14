public class ParkingPardon
{
    private readonly TimeSpan pardonDuration = TimeSpan.FromMinutes(2);

    public bool IsPardoned(TimeSpan parkingDuration)
    {
        return parkingDuration < pardonDuration;
    }
}