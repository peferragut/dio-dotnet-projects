namespace Parking
{
    public class ParkingMain
    {

        private string? _input;
        private static readonly string[] OPTIONS = { "1", "2", "3", "4" };
        private ParkingManager? parkingManager;

        static void Main(string[] args)
        {
            ParkingMain parkingMain = new ParkingMain();
            parkingMain.Start();            
        }

        // private
        private void Start() 
        {
            Console.Clear();
            Console.WriteLine("Welcome to Kundera Parking app!");
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1 - Add a vehicle");
            Console.WriteLine("2 - Remove a vehicle");
            Console.WriteLine("3 - List all parked vehicles");
            Console.WriteLine("4 - Finish");

            parkingManager = new ParkingManager();

            while (true)
            {
                _input = Console.ReadLine();
                if (_input != null)
                {
                    if (!OPTIONS.Contains(_input))
                    {
                        Console.WriteLine("Invalid input! Choose between options from 1 to 4.");
                        continue;
                    }
                    
                    parkingManager.ProcessOption(_input);
                }
            }
        }
    }
}
