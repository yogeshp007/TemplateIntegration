using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TemplateIntegration.Controllers
{
    public class DemoController : ApiController
    {
        List<string> li = new List<string>() { "Yagnesh", "Ruchi", "Pruthvi" };

        public List<string> GetStringData()
        {
            return li;
        }

        public List<int> GetIntData()
        {
            return new List<int>() { 100,200,300,400,500 };
        }

        [HttpPost]
        public List<string> PostData(string name)
        {
            li.Add(name);
            return li;
        }

    }
}
