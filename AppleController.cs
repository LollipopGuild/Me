using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Me.Web.Controllers
{
    [Route("apple-app-site-association")]
    public class AppleController : Controller
    {
        private string _AppLinks = 
        @"
        {
          ""applinks"": {
            ""apps"": [],
            ""details"": [
              {
                ""appID"": ""AL4362J8FY.com.alchebyte.me"",
                ""paths"": [
                  ""/IOPClaimVerification/*""
                ]
              }
            ]
          }
        }";

        [HttpGet]
        public IActionResult Index()
        {
            return Content(_AppLinks, "application/json");
        }
    }
}