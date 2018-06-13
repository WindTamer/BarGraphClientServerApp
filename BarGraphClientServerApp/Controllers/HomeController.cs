using System.IO;
using System.Web;
using System.Web.Mvc;

namespace BarGraphClientServerApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ClientSPA()
        {

            return View("ClientSPA");
        }


        // Validate the input file content type
        private bool IsValidContentType(string contentType)
        {
            return contentType.Equals("text/plain");
        }


        // Accept a file from an HTML input field, and save it on server
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase File)
        {

            if (File != null && IsValidContentType(File.ContentType))
            {
                string path = Server.MapPath("~/App_Data/");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                File.SaveAs(path + "data.txt");
            }
            else
            {
                return View("Error");
            }

            return View("ClientSPA");

        }
    }
}
