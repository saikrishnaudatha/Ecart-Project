using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart
{
    class Item
    {
        public int item_id, iprice, istock;
        public string iname, idesc, irem;




        //public int Item_id { get => item_id; set => item_id = value; }
        //public string Iname { get => iname; set => iname = value; }
        //public string Idesc { get => idesc; set => idesc = value; }
        //public int Istock { get => istock; set => istock = value; }
        //public string Irem { get => irem; set => irem = value; }
        //public int Iprice { get => iprice; set => iprice = value; }


        public Item() { }


        public Item(int item_id, string iname, string idesc, int istock, string irem, int price)
        {
            this.item_id = item_id;
            this.iname = iname;
            this.idesc = idesc;
            this.istock = istock;
            this.irem = irem;
            this.iprice = price;


        }

    }
}
