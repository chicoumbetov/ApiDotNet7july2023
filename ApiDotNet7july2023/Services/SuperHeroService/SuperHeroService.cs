using System;
using ApiDotNet7july2023.Models;

namespace ApiDotNet7july2023.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                },
                new SuperHero {
                    Id = 2,
                    Name = "Batman",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place = "Gotham"
                }
            };

        public List<SuperHero> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int id)
        {

            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null; // NotFound("Sorry, but this hero doesn't exist.");

            superHeroes.Remove(hero);
            return superHeroes;
        }

        public List<SuperHero> GetAllHeroes()
        {
            return superHeroes;
        }

        public SuperHero? GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null; // NotFound("Sorry, but this hero doesn't exist.");
            return hero;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero heroRequest)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null; // NotFound("Sorry, but this hero doesn't exist.");

            hero.FirstName = heroRequest.FirstName;
            hero.LastName = heroRequest.LastName;
            hero.Name = heroRequest.Name;
            hero.Place = heroRequest.Place;

            return superHeroes;
        }
    }
}

