using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDotNet7july2023.Controllers
{
    [Route("api/[controller]")]
    public class SuperHeroController : Controller
    {
        private static List<Models.SuperHero> superHeroes = new List<Models.SuperHero>
            {
                new Models.SuperHero {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                },
                new Models.SuperHero {
                    Id = 2,
                    Name = "Batman",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place = "Gotham"
                }
            };

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<List<Models.SuperHero>>> GetAllHeroes()
        {
            return Ok(superHeroes);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Models.SuperHero>>> GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return NotFound("Sorry, but this hero doesn't exist.");
            return Ok(hero);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

