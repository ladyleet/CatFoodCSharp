﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace GrumpyCatFoodCSharp.Controllers

{

    [Route("api/[controller]")]
    public class CatFoodController : Controller


    {
        static Dictionary<string, string> catFoodKeyWords = new Dictionary<string, string>() {
                {"pizza", "pizza response"},
                {"burger", "burger response"},
                {"donut", "donut response"},
                {"hot dog", "hot dog response"},
                {"fries", "fries response"},
                {"goldfish", "goldfish response"},
                {"taco", "taco response"},
                {"ta", "tacoooo response"}

            };
        // GET: api/values
        [HttpGet]
        public IEnumerable<KeyValuePair<string, string>> Get([FromQuery]string food)
        {
            //var key = HttpUtility.UrlDecode(food);
            return CatFoodController.catFoodKeyWords.Where((x) => x.Key.StartsWith(food))
                                   .ToArray();

        }
    }
}
