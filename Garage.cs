namespace GarageApp
{

    abstract class CheckSlot
    {


        public static void Check(Vehicle vehicle, Garage garage)
        {
            List<ParkingSlot> slots = garage.GetAllSlots(); 
            ParkIn.OccupySlot(slots[1], vehicle);
        }

    }

    abstract class ParkIn
    {

        public static int vehicleNo = 0;
        public static void OccupySlot(ParkingSlot parkingSlot, Vehicle vehicle)
        {
            parkingSlot.vehicle = vehicle;
            vehicleNo++;
        }
    }

    abstract class ParkOut
    {
        public static void UnOccupySlot(ParkingSlot parkingSlot)
        {
            parkingSlot.vehicle = null;
        }
    }

    class Vehicle
    {
        public int ID { get; set; }
        public string? ModelName { get; set; }
        public int ModelYear { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public Vehicle(decimal width, decimal depth)
        {
            Width = width;
            Depth = depth;
        }

        // public Vehicle(int id, string? modelName, int modelYear, decimal width, decimal depth, DateTime arrivalTime, DateTime departureTime)
        // {
        //     ID = id;
        //     ModelName = modelName;
        //     ModelYear = modelYear;
        //     Width = width;
        //     Depth = depth;
        //     ArrivalTime = arrivalTime;
        //     DepartureTime = departureTime;
        // }
    }

    class ParkingSlot
    {
        public decimal width;
        public decimal depth;
        // public bool occupied;
        public Vehicle? vehicle;

        public ParkingSlot(decimal width, decimal depth, Vehicle vehicle)
        {
            this.width = width;
            this.depth = depth;
            this.vehicle = vehicle;
        }

    }

    class Garage
    {

        private List<ParkingSlot> parkingSlots;
        private List<Vehicle> vehicles;
        public int capacity;

        public Garage(int capacity)
        {
            parkingSlots = new List<ParkingSlot>();
            this.capacity = capacity;
        }

        public List<ParkingSlot> GetAllSlots()
        {
            return parkingSlots;
        }


        public void AddSlot(ParkingSlot parkingSlot)
        {
            parkingSlots.Add(parkingSlot);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }



    }
}