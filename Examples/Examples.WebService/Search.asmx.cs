using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Examples.WebService
{
    /// <summary>
    /// Summary description for Search
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Search : System.Web.Services.WebService
    {

        [WebMethod]
        public Student Serach(string name)
        {
            var students = new List<Student>
            {
                new Student {Name="zhang san",Age=20 },
                new Student {Name="Li si",Age=20 }
            };

            return students.First(s => s.Name == name);
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
