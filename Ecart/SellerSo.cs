using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart
{
    class Sellerso : Seller
    {
        int prs, prs1;
        List<Seller> ls = new List<Seller>();
        public bool signin(int sid, string pswd)
        {

            Seller s = ls.Find(res => sid.Equals(res.Sid));
            if (s != null)
                return true;
            else
                return false;
        }
        public string Register(int sid, string sname, string spswd, string compname, string gstin, string det, string sadd, string cweb, string smail, int sno)
        {
            ls.Add(new Seller(sid, sname, spswd, compname, gstin, det, sadd, cweb, smail, sno));
            return "registered Successfully..!!!";
        }

        ItemBo ib = new ItemBo();


        public void display()
        {
            do
            {
                Console.WriteLine("\nWhich Operation you need to perform\n1.Display\n2.Search\n3.Exit\nEnter your choice");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        ib.DisplayProducts();
                        break;

                    case 2:
                        ib.Search();
                        break;

                }
                Console.WriteLine("Do u want to see operations again ?Press 1");
                prs1 = int.Parse(Console.ReadLine());
            } while (prs1 == 1);

        }

        public void show()
        {
            do
            {
                Console.WriteLine("\nWhich Operation you need to perform\n1.Add items\n2.Display\n3.Search\n4.Exit\nEnter your choice");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Enter how many categories you need to enter");
                        int categ = int.Parse(Console.ReadLine());
                        for (int caat = 0; caat < categ; caat++)
                        {
                            Console.WriteLine("Enter Category Id");
                            int catid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Category Name");
                            string catname = Console.ReadLine();

                            Console.WriteLine("Enter SubCategory Id");
                            int scid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter SubCategory Name");
                            string scname = Console.ReadLine();
                            Console.WriteLine("Enter SubCategory Description");
                            string scdes = Console.ReadLine();


                            Console.WriteLine("Enter Item Id");
                            int iid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Item Name");
                            string iname = Console.ReadLine();
                            Console.WriteLine("Enter Item Description");
                            string ides = Console.ReadLine();
                            Console.WriteLine("Enter stock no");
                            int stock = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Item Remarks");
                            string rem = Console.ReadLine();
                            Console.WriteLine("Enter Item Price");
                            int price = int.Parse(Console.ReadLine());

                            ib.AddItem(iid, catid, scid, iname, catname, scname, stock, ides, scdes, rem, price);
                        }

                        break;

                    case 2:
                        ib.DisplayProducts();
                        break;

                    case 3:
                        ib.Search();
                        break;

                    case 4:
                        //Console.WriteLine("\nEnter SubCategory Id to enter more items in it :");
                        //int sub = int.Parse(Console.ReadLine());
                        //ib.AddMoreItems(sub);
                        break;

                    //case 4:
                    //    System.Exit(0);

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine("Do u want to perform operations again ?Press 1");
                prs = int.Parse(Console.ReadLine());
            } while (prs == 1);
        }
    }
}
