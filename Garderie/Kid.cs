using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Garderie
{
    [Serializable]
    public class Kid
    {
        private long id;
        private string name;
        private string address;
        private Parent parent;
        private Teacher teacher;
        private Group group;

        public Kid() { }
        
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

        public Parent Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
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

        public Group Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
            }
        }

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
    }
}
