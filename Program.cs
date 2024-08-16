class Program
{
	static void Main(string[] args)
	{
		// Creating an instance of Car class (which inherits from Vehicle)
		Car myCar = new Car("Honda", "Civic", 2022, 4);

		// Displaying the car info using inherited and overridden methods
		myCar.DisplayInfo();

		// Output: 
		// Car: 2022 Honda Civic with 4 doors
	}
}
