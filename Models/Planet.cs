namespace AstronomyApp.Models;
public class Planet:CelestialBody
{
    public double Distance { get; set; }
    public double Gravity { get; set; }
    public Planet(string? name, double mass, double radius,double Distance,double Gravity) : base(name, mass, radius)
    {
        this.Distance =Distance;
        this.Gravity = Gravity;
    }


    public override void Describe()
    {
        System.Console.WriteLine($"Name = {Name}\n Mass: {Mass}\nRadius: {Radius}\nGravity: {Gravity}\nDistance: {Distance}");
    }
}