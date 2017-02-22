using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Garderie;
using System.Configuration;
using System.Data.SqlClient;

namespace WebAPITest.Models
{
    public class GarderieModel
    {
        
        public GarderieModel() { }


        public static GarderieClass GetGarderieInfo() {

            var con = ConfigurationManager.ConnectionStrings["Data Source=.\'SQLEXPRESS;Initial Catalog=garderie;Integrated Security=True;MultipleActiveResultSets=True"].ToString();

            GarderieClass myGarderie = new GarderieClass();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from garderie";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        myGarderie.Name = oReader["Garderie_Name"].ToString();
                        myGarderie.Address = oReader["Garderie_Address"].ToString();
                    }

                    myConnection.Close();
                }
            }
            return myGarderie;
             
                      

        } 

        
        
        
        
        







    }
}