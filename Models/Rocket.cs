namespace AstronomyApp.Models;
public class Rocket : SpaceShip
{
    public Rocket(string name, double mass, double fuel, int crewCapacity, double thrust, double specificlmpulse) : base(name, mass, fuel, crewCapacity, thrust, specificlmpulse)
    {
    }

    public override void Land()
    {
        System.Console.WriteLine("The Rocket Is Landed");
    }

    public override void Launch()
    {
        System.Console.WriteLine("The Rocket Is Launched");
    }
}