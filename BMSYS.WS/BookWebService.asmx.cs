﻿using System.Web.Services;

namespace BMSYS.WS
{
    /// <summary>
    /// Summary description for BookWebService
    /// </summary>
    [WebService(Namespace = "http://BookManagementSystem.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BookWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
