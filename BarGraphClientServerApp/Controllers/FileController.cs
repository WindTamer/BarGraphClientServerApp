using System.Collections.Generic;
using System.Web.Http;
using BarGraphClientServerApp.Models;
using BarGraphClientServerApp.Services;

namespace BarGraphClientServerApp.Controllers
{
    public class FileController : ApiController
    {

        // GET api/file
        public IEnumerable<Bar> Get()
        {
            
            TxtToObjectConverterService service = new TxtToObjectConverterService();
            return service.GetDataList();
        }
    }
}

