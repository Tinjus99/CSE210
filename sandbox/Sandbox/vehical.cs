using System.Runtime.CompilerServices;

public class Vehicle
{
    private int _YearManufactured;
    private string _Manufacturerer;
    private string _ModelName;


    public Vehicle(int YearManufactured, string Manufacturerer, string ModelName)
    {
        _YearManufactured = YearManufactured;
        _Manufacturerer = Manufacturerer;
        _ModelName = ModelName;
    }

    public int GerYearManufactured()
    {
        return _YearManufactured;
    }
}

public class Car : Vehicle
{
    private int _NumberOfDoors;
    public Car(int YearManufactured, string Manufacturerer, string ModelName, int NumberOfDoors)
    : base(YearManufactured, Manufacturerer, ModelName)
    {
        _NumberOfDoors = NumberOfDoors;
    }

}

public class Ford : Car
{
    public Ford(int YearManufactured, string ModelName, int NumberOfDoors)
    : base(YearManufactured, "Ford", ModelName, NumberOfDoors)
    {

    }
}

public class Program2
{
    public static void Main(string[] args)
    {
        Car car1 = new Car(2009, "Nissan", "Altima", 4);

        Ford ford1 = new Ford(2000, "F-150", 4);
    }
}