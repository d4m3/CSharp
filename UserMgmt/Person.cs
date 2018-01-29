using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMgmt
{
    class Person
    {
        int ID;
        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string name;
    }
}
