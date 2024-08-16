public class Car : Vehicle
{
	public int NumberOfDoors { get; set; }

	// Constructor for Car class
	public Car(string make, string model, int year, int numberOfDoors)
		: base(make, model, year)
	{
		NumberOfDoors = numberOfDoors;
	}

	// Override the DisplayInfo method to include the number of doors
	public new void DisplayInfo()
	{
		Console.WriteLine($"Car: {Year} {Make} {Model} with {NumberOfDoors} doors");
	}
}
