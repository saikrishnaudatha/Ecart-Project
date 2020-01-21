using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart
{
    class Seller
    {
        int sid, sno;
        string sname, spswd, compname, gstin, det, sadd, cweb, smail;

        public int Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
        public string Spswd { get => spswd; set => spswd = value; }
        public string Compname { get => compname; set => compname = value; }
        public string Gstin { get => gstin; set => gstin = value; }
        public string Details { get => det; set => det = value; }
        public string Cweb { get => cweb; set => cweb = value; }
        public string Smail { get => smail; set => smail = value; }
        public int Sno { get => sno; set => sno = value; }

        public Seller() { }


        public Seller(int sid, string sname, string spswd, string compname, string gstin, string det, string sadd, string cweb, string smail, int sno)
        {
            this.sid = sid;
            this.sname = sname;
            this.spswd = spswd;
            this.compname = compname;
            this.gstin = gstin;
            this.det = det;
            this.sadd = sadd;
            this.cweb = cweb;
            this.smail = smail;
            this.sno = sno;
        }

    }
}
