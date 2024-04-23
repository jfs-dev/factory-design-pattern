using factory_design_pattern.Entities;
using factory_design_pattern.Enums;
using factory_design_pattern.Interfaces;

namespace factory_design_pattern.Factories;

public class SuperHeroFactory
{
    public ISuperHero CreateHero(ESuperHeroType superHeroType)
    {
        return superHeroType switch
        {
            ESuperHeroType.IronMan => new IronMan(),
            ESuperHeroType.SpiderMan => new SpiderMan(),
            _ => throw new ArgumentException("Super-herói desconhecido!"),
        };
    }
}
