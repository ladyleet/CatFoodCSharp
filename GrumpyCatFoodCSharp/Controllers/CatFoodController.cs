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
        public IEnumerable<string> Get([FromQuery]string foods)
        {
            var catFoodKeyWords = new Dictionary<string, string>() {
                {"pizza", "pizza emoji"},
                {"burger", "burger emoji"}

            };

            if (catFoodKeyWords.ContainsKey(foods))
                return new string[] { catFoodKeyWords[foods] };

            return Enumerable.Empty<string>();
        }
    }
}
