using AstronomyApp.Models;
//Planets
Planet Planet1 = new Planet("Earth",25_000,64_000,15_000,9.8);
System.Console.WriteLine("Planet 1");
Planet1.Describe();System.Console.WriteLine();
Planet Planet2 = new Planet("Mars",34_000,55_000,19_000,6.8);
System.Console.WriteLine("Planet 2");
Planet2.Describe();
System.Console.WriteLine();System.Console.WriteLine();

//Moons
CelestialBody Moon1 = new Moon("Moon",4_000,3_000,Planet1);
CelestialBody Moon2 = new Moon("Mashhor",45_000,38_000,Planet2);
//Rockets
Rocket rocket1 = new Rocket("XPG_15",1234,45000,4,7_000,90);
rocket1.Launch();
rocket1.TravelTo(Planet1);
rocket1.Land();
