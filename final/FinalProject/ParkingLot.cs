public class ParkingLot
{
    private int capacity;
    private int availableSpaces;
    private Dictionary<string, DateTime> parkedCars;

    public ParkingLot(int capacity)
    {
        this.capacity = capacity;
        this.availableSpaces = capacity;
        this.parkedCars = new Dictionary<string, DateTime>();
    }

    public string ParkCar(string carId)
    {
        if (availableSpaces > 0)
        {
            parkedCars[carId] = DateTime.Now;
            availableSpaces--;
            return $"Car {carId} parked successfully.";
        }
        else
        {
            return "Parking lot is full. Cannot park car.";
        }
    }

     public string RetrieveCar(string carId)
    {
        if (parkedCars.ContainsKey(carId))
        {
            DateTime parkingStartTime = parkedCars[carId];
            TimeSpan parkingDuration = DateTime.Now - parkingStartTime;
            double parkingFee = CalculateParkingFee(parkingDuration);
            parkedCars.Remove(carId);
            availableSpaces++;
            
            var parkingPardon = new ParkingPardon();
            if (parkingPardon.IsPardoned(parkingDuration))
            {
                return $"Car {carId} retrieved successfully. Parking duration: {parkingDuration.TotalMinutes:F2} minutes. No parking fee under 2mins of parking time.";
            }
            else
            {
                return $"Car {carId} retrieved successfully. Parking duration: {parkingDuration.TotalHours:F2} hours, Parking fee: ${parkingFee:F2}";
            }
        }
        else
        {
            return $"Car {carId} is not parked in the parking lot.";
        }
    }

    private double CalculateParkingFee(TimeSpan parkingDuration)
    {
        
        return Math.Ceiling(parkingDuration.TotalHours)* 10;
    }

    public int AvailableSpaces => availableSpaces;
}