using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart
{
    abstract class Categories
    {
        public int cid;
        public string cname;
        public Categories() { }
        //public int Cid { get => cid; set => cid = value; }
        //public string Cname { get => cname; set => cname = value; }

        public Categories(int id, string name)
        {
            this.cid = id;
            this.cname = name;
        }


    }
}
