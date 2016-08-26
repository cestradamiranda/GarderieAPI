using Garderie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    public class KidController : ApiController
    {
        
        [HttpGet]
        public IEnumerable<Kid> GetAllKids() {

            return CrudKids.GetAllKids();
        }

        public Kid GetKidById(long id) {
            return CrudKids.GetKid(id);
        }


        
        
        


        

    }
}
