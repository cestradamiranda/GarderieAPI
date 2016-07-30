using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderie
{
    public class Garderie
    {
        private string name;
        private string address;
        private List<Teacher> teachers;
        private List<Group> groups;

        public Garderie() { }

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

        public List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }

            set
            {
                teachers = value;
            }
        }

        public List<Group> Groups
        {
            get
            {
                return groups;
            }

            set
            {
                groups = value;
            }
        }

       




    }
}
