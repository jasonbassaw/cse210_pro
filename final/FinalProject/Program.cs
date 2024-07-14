public class Program
{
    public static void Main(string[] args)
    {
        ParkingLot parkingLot = new ParkingLot(10);
        bool running = true;

        while (running)
        {
            Console.WriteLine("WELCOME TO ARLO'S PARKING LOT! Secure Your Car and Roam Without Stress! Park your car for just $5/hr and no fees under 2mins. Please choose your option:");
            Console.WriteLine("1. Park a Car");
            Console.WriteLine("2. Retrieve a Car");
            Console.WriteLine("3. View Available Parking Spots");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Car ID to park: ");
                    string carIdToPark = Console.ReadLine();
                    Console.WriteLine(parkingLot.ParkCar(carIdToPark));
                    break;
                case "2":
                    Console.Write("Enter Car ID to retrieve: ");
                    string carIdToRetrieve = Console.ReadLine();
                    Console.WriteLine(parkingLot.RetrieveCar(carIdToRetrieve));
                    break;
                case "3":
                    Console.WriteLine($"Available spaces: {parkingLot.AvailableSpaces}");
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}