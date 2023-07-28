using System;
namespace ApiDotNet7july2023.Services.SuperHeroService
{
	public interface ISuperHeroService
	{
        List<Models.SuperHero> GetAllHeroes();

        Models.SuperHero? GetSingleHero(int id);

        List<Models.SuperHero> AddHero(Models.SuperHero hero);

        List<Models.SuperHero>? UpdateHero(int id, Models.SuperHero heroRequest);

        List<Models.SuperHero>? DeleteHero(int id);
    }
}

