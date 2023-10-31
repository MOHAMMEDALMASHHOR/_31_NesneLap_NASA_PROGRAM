namespace AstronomyApp.Models;
public abstract class SpaceShip
{
    public string? Name { get; set; }
    public double Mass { get; set; }
    public double Fuel { get; set; }
    public int CrewCapacity { get; set; }
    public double Thrust { get; set; }
    public double Specificlmpulse { get; set; }
    protected SpaceShip(string name, double mass, double fuel, int crewCapacity, double thrust, double specificlmpulse)
    {
        Name = name;
        Mass = mass;
        Fuel = fuel;
        CrewCapacity = crewCapacity;
        Thrust = thrust;
        Specificlmpulse = specificlmpulse;
    }

    public abstract void Launch();
    public abstract void Land();
    public double TravelTo(Planet plant){
         var TraveledDistance =(plant.Distance/CaluclateTravelDistance(plant));
        System.Console.WriteLine($"Traveld To {plant.Name}, The Traveled Distance is {TraveledDistance}");
        return TraveledDistance;
    }
    protected double CaluclateDeltaV(Planet plant){
        return (Specificlmpulse*plant.Gravity*Math.Log((Mass+Fuel)/Mass));
    }
    protected double CaluclateTravelDistance(Planet plant){
        return ((2*CaluclateDeltaV(plant))/(Thrust*1000));
    }


}