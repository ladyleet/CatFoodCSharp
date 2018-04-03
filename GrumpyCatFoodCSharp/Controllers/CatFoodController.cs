using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GrumpyCatFoodCSharp.Controllers
{
    [Route("api/[controller]")]
    public class CatFoodController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get([FromQuery]string food)
        {
            var catFoodKeyWords = new Dictionary<string, string>() {
                {"pizza", "pizza response"},
                {"burger", "burger response"},
                {"donut", "donut response"},
                {"hot dog", "hot dot response"},
                {"fries", "fries response"},
                {"goldfish", "goldfish response"},
                {"taco", "taco response"}

            };

            if (catFoodKeyWords.ContainsKey(food))
                return new string[] { catFoodKeyWords[food] };

            return Enumerable.Empty<string>();
        }
    }
}
