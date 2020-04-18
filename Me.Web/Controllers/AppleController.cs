using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace Me.Web.Controllers
{
    [Route("apple-app-site-association")]
    public class AppleController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;

        public AppleController(IWebHostEnvironment environment)
        {
            _hostingEnvironment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath, "apple-app-site-association");
            return Content(System.IO.File.ReadAllText(path), "application/json");
        }
    }
}