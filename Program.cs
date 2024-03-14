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
    Console.WriteLine("4. Calculate Total Income");
    Console.WriteLine("5. Calculate Total Cars Parked");
    int decision;
    while (true)
    {
        try
        {
            decision = int.Parse(Console.ReadLine());
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    if (decision == 1)
    {

        decimal depth;
        decimal width;
        int ModelYear;
        string ModelName;

        while (true)
        {
            try
            {
                depth = decimal.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        while (true)
        {
            try
            {
                width = decimal.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        while (true)
        {
            try
            {
                ModelYear = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        while (true)
        {
            try
            {
                ModelName = Console.ReadLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
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

    if (decision == 4)
    {
        IncomeCalculator.DisplayIncome();
    }

    if (decision == 5)
    {
        VehicleCounter.DisplayVehicleCount();
    }



}


