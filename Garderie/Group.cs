using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderie
{
    public class Group
    {
        private long id;
        private Teacher teacher;
        private List<Kid> kids;

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

        public Teacher Teacher
        {
            get
            {
                return teacher;
            }

            set
            {
                teacher = value;
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

        public Group() { }

       

    }
}
