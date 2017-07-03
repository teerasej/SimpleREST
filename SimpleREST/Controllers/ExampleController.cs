using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleREST.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleREST.Controllers
{
    [Route("api/[controller]")]
    public class ExampleController : Controller
    {
        [HttpGet]
        public IEnumerable<int> ListProducts(){
            return new int[] { 1, 2, 3 };
        }

        [HttpGet("/bool")]
        public IActionResult IsTrue() {

            var result = new BoolResult { Result = true };

            return new ObjectResult(result);
        }
    }
}
