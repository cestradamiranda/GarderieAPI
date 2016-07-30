using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderie
{
   public class Parent
    {

        private string name;
        private string address;
        private string telephoneNumber;
        private Kid kid;


        public Parent() { }

       
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string TelephoneNumber
        {
            get
            {
                return telephoneNumber;
            }

            set
            {
                telephoneNumber = value;
            }
        }

        public Kid Kid
        {
            get
            {
                return kid;
            }

            set
            {
                kid = value;
            }
        }
    }
}
