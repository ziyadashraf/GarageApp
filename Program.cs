using GarageApp;


Console.WriteLine("Enter garage capacity");

int capacity;
capacity = int.Parse(Console.ReadLine());

Garage garage = new(capacity);

Console.WriteLine("Enter parking slots dimensions");

for (int i = 0; i < capacity; i++)
{
    decimal depth;
    decimal width;
    depth = decimal.Parse(Console.ReadLine());
    width = decimal.Parse(Console.ReadLine());

    garage.AddSlot(new ParkingSlot(width, depth, null));

}

List<ParkingSlot> slots = garage.GetAllSlots();

Console.WriteLine("1- Add Car to Garage");
int x = int.Parse(Console.ReadLine());

if (x == 1)
{
    Vehicle vehicle = new Vehicle(20, 30);
    CheckSlot.Check(vehicle, garage);
    // garage.AddVehicle(new Vehicle(20, 30, DateTime.Now));
}

