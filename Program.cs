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

while (true)
{
    Console.WriteLine("Choose your next action:");
    Console.WriteLine("1. Add Car to Garage");
    Console.WriteLine("2. Remove Car from Garage");
    Console.WriteLine("3. Display All Slots");

    int decision = int.Parse(Console.ReadLine());

    if (decision == 1)
    {
        decimal depth = decimal.Parse(Console.ReadLine());
        decimal width = decimal.Parse(Console.ReadLine());
        int ModelYear = int.Parse(Console.ReadLine());
        string ModelName = Console.ReadLine();

        Vehicle vehicle = new Vehicle(ModelName, ModelYear, width, depth, DateTime.Now);
        CheckSlot.Check(vehicle, garage);
    }

    if (decision == 2)
    {

        Console.WriteLine($"Choose vehicle to remove");

        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].vehicle != null)
            {
                Console.WriteLine($"Slot {i + 1}: {slots[i].vehicle.ModelName}");
            }
        }

        int slotNo = int.Parse(Console.ReadLine());
        ParkOut.UnOccupySlot(slots[slotNo - 1]);

    }

    if (decision == 3)
    {

        Console.WriteLine($"All slots:");

        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].vehicle != null)
            {
                Console.WriteLine($"Slot {i}: {slots[i].vehicle.ModelName}");
            }
            else
            {
                Console.WriteLine($"Slot {i}: Vacant with depth: {slots[i].depth} and width: {slots[i].width}");

            }
        }



    }



    // Console.WriteLine("3. Add Car to Garage");
    // Console.WriteLine("1. Add Car to Garage");



    // CheckSlot.Check(vehicle, garage);
    // garage.AddVehicle(new Vehicle(20, 30, DateTime.Now));


    // foreach (ParkingSlot slot in slots)
    // {

    //     Console.WriteLine(slot.vehicle.ID);

    // }

}


