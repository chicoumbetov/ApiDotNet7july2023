using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiDotNet7july2023.Services.SuperHeroService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDotNet7july2023.Controllers
{
    [Route("api/[controller]")]
    public class SuperHeroController : Controller
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
            {
                _superHeroService = superHeroService;
            }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<List<Models.SuperHero>>> GetAllHeroes()
        {
            return _superHeroService.GetAllHeroes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.SuperHero>> GetSingleHero(int id)
        {
            var result = _superHeroService.GetSingleHero(id);
            if (result is null)
                return NotFound("Hero not found.");

            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<List<Models.SuperHero>>> AddHero(Models.SuperHero hero)
        {
            var result = _superHeroService.AddHero(hero);
            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Models.SuperHero>>> UpdateHero(int id, Models.SuperHero heroRequest)
        {
            var result = _superHeroService.UpdateHero(id, heroRequest);
            if (result is null)
                return NotFound("Hero not found.");

            return Ok(result);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Models.SuperHero>>> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);
            if (result is null)
                return NotFound("Hero not found.");

            return Ok(result);
        }
    }
}

