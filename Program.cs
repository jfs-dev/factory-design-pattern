using factory_design_pattern.Enums;
using factory_design_pattern.Factories;
using factory_design_pattern.Interfaces;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Factory Design Pattern");
Console.WriteLine("----------------------");
Console.ForegroundColor = ConsoleColor.Magenta;

SuperHeroFactory superHeroFactory = new();

ISuperHero spiderMan = superHeroFactory.CreateHero(ESuperHeroType.SpiderMan);
spiderMan.UseSuperPower();

ISuperHero ironMan = superHeroFactory.CreateHero(ESuperHeroType.IronMan);
ironMan.UseSuperPower();
