using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatorService
{
    /// <summary>
    /// Summary description for CalService
    /// </summary>
    [WebService(Namespace = "http://www.met.edu/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalService : System.Web.Services.WebService
    {

        [WebMethod]//expose to client
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int Add(int x , int y)
        {
            return x + y;
        }

        [WebMethod]
        public int Sub(int x, int y)
        {
            return x - y;
        }

        [WebMethod]
        public int Mul(int x, int y)
        {
            return x * y;
        }

        [WebMethod]
        public int Div(int x, int y)
        {
            return x / y;
        }



        public string Dummy()
        {
            return "Dummy";
        }
    }
}
