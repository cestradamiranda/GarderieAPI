using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Garderie;

namespace WebAPITest.Models
{
    public class CrudKids
    {
        public static IEnumerable<Kid> GetAllKids()
        {
            List<Kid> myKids = new List<Kid>();
            Kid kid1 = new Kid();
            kid1.Name = "Carlos";
            kid1.Address = "Montreal";
            
             


            myKids.Add(kid1);

            return myKids;
        }

        public static Kid GetKid(long id)
        {
            Kid kid1 = new Kid();
            kid1.Id = 1;
            kid1.Name = "Carlos";
            kid1.Address = "Montreal";

            if (id == kid1.Id)
            {
                return kid1;
            }
            else {
                return null;
            }


        }
    }
}