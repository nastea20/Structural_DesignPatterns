using System;

// Base vehicle interface
public interface IVehicle
{
    void Rent(string customer);
}

// Concrete vehicle class
public class Car : IVehicle
{
    public void Rent(string customer)
    {
        Console.WriteLine($"Car rented to {customer}");
    }
}

// Decorator interface
public interface IVehicleDecorator : IVehicle
{
}

// Concrete decorator classes
public class GpsDecorator : IVehicleDecorator
{
    private readonly IVehicle _vehicle;

    public GpsDecorator(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public void Rent(string customer)
    {
        _vehicle.Rent(customer);
        Console.WriteLine("GPS added to the car");
    }
}

public class MusicDecorator : IVehicleDecorator
{
    private readonly IVehicle _vehicle;

    public MusicDecorator(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public void Rent(string customer)
    {
        _vehicle.Rent(customer);
        Console.WriteLine("Music player added to the car");
    }
}

// Third-party car rental service interface
public interface IThirdPartyRentalService
{
    void RentCar(string customerName, string carModel);
}

// Adapter class
public class ThirdPartyRentalAdapter : IVehicle
{
    private readonly IThirdPartyRentalService _service;

    public ThirdPartyRentalAdapter(IThirdPartyRentalService service)
    {
        _service = service;
    }

    public void Rent(string customer)
    {
        // Map our interface to the third-party service interface
        _service.RentCar(customer, "basic car");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Rent a basic car
        IVehicle car = new Car();
        car.Rent("John");

        // Rent a car with GPS
        IVehicle carWithGps = new GpsDecorator(new Car());
        carWithGps.Rent("Alice");

        // Rent a car with GPS and music player
        IVehicle carWithAccessories = new MusicDecorator(new GpsDecorator(new Car()));
        carWithAccessories.Rent("Bob");

        // Rent a car through the third-party rental service adapter
        IThirdPartyRentalService rentalService = new MyRentalService();
        IVehicle rentalAdapter = new ThirdPartyRentalAdapter(rentalService);
        rentalAdapter.Rent("Charlie");
    }
}

// Example third-party rental service
public class MyRentalService : IThirdPartyRentalService
{
    public void RentCar(string customerName, string carModel)
    {
        Console.WriteLine($"{carModel} rented to {customerName} through third-party rental service");
    }
}
