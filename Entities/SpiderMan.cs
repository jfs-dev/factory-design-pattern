using factory_design_pattern.Interfaces;

namespace factory_design_pattern.Entities;

public class SpiderMan : ISuperHero
{
    public void UseSuperPower()
    {
        Console.WriteLine("Homem-Aranha usa seu sentido de aranha que o avisa sobre o perigo!");
    }
}
