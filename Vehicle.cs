public class Vehicle
{
	// Fields common to all vehicles
	public string Make { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }

	// Constructor
	public Vehicle(string make, string model, int year)
	{
		Make = make;
		Model = model;
		Year = year;
	}

	// Method to display vehicle info
	public void DisplayInfo()
	{
		Console.WriteLine($"Vehicle: {Year} {Make} {Model}");
	}
}
	