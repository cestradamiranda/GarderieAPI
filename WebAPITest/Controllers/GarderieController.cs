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
    public class GarderieController : ApiController
    {

        public GarderieClass GetGarderie()
        {
            return GarderieModel.GetGarderieInfo();


        }


    }
}
