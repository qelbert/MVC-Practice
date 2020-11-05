using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("/helloworld/")]
    public class HelloController : Controller
    {
        // GET: /<controllers>/
        [HttpGet]
        //[Route("/helloworld/")]
        public IActionResult Index()
        {
            //string html = "<h1>Hello world!</h1>";
            
            string html = //"<form method='post' action='/hello/welcome'>" +
                "<form method='post' action='/helloworld/welcome'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        // GET: /<conroller>/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome")]
        //[Route("/helloworld/welcome/{name?}")]

        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
             public IActionResult Welcome(string name="World!")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

    }
}
