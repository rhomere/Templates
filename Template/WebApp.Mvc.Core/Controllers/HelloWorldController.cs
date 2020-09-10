using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Services.Api.Mvc.Core.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
            //return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int id = 1)
        {
            //return "This is the Welcome action method...";

            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        }
    }
}
