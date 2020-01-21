using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart
{
    class Buyer
    {
        int bid, bno;
        string bname, bpswd, bmail;

        public int Bid { get => bid; set => bid = value; }
        public string Bname { get => bname; set => bname = value; }
        public string Bpswd { get => bpswd; set => bpswd = value; }
        public string Bmail { get => bmail; set => bmail = value; }
        public int Bno { get => bno; set => bno = value; }

        public Buyer() { }
        public Buyer(int bid, string bname, string bpswd, string bmail, int bno)
        {
            this.bid = bid;
            this.bname = bname;
            this.bpswd = bpswd;
            this.bmail = bmail;
            this.bno = bno;


        }

    }
}
