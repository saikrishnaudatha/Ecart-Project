using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart
{
    class SubCategory : Categories
    {
        public int scid;
        public string scname;
        public string scdes;

        //public int Scid { get => scid; set => scid = value; }
        //public string Scname { get => scname; set => scname = value; }
        //public string Scdes { get => scdes; set => scdes = value; }
        public SubCategory() { }

        public SubCategory(int cid, string cname, int scid, string scname, string scdes) : base(cid, cname)
        {

            this.scid = scid;
            this.scname = scname;
            this.scdes = scdes;
        }

    }
}
