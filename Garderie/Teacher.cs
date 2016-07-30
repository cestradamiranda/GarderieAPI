using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderie
{
    public class Teacher
    {
        private long id;
        private string name;
        private string address;
        private List<Kid> kids;

        public Teacher() { }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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

        public List<Kid> Kids
        {
            get
            {
                return kids;
            }

            set
            {
                kids = value;
            }
        }
    }
}
