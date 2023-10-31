namespace AstronomyApp.Models;
public class Moon : CelestialBody
{
    public Planet ParentPlanet { get; set; }
    public Moon(string? name, double mass, double radius,Planet ParentPlanet) : base(name, mass, radius)
    {
        this.ParentPlanet = ParentPlanet;
    }

    public override void Describe()
    {
        System.Console.WriteLine($"Name = {Name}\n Mass: {Mass}\nRadius: {Radius}\nPlanet: {ParentPlanet}");
    }
}