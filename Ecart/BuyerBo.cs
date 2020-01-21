using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart
{
    class Buyerbo : Buyer
    {
        List<Buyer> lb = new List<Buyer>();
        public bool signin(int bid, string bpswd)
        {

            Buyer b = lb.Find(res => (bid.Equals(res.Bid)));
            if (b != null)
                return true;
            else
                return false;


        }
        public string Register(int bid, string bname, string bpswd, string bmail, int bno)
        {
            lb.Add(new Buyer(bid, bname, bpswd, bmail, bno));
            return "registered Successfully..!!!";
        }
    }
}
