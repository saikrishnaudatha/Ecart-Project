using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart
{
    class Program
    {

        static void Main(string[] args)
        {
            int bid, bno;
            string bname, bpswd, bmail;

            Buyerbo bb = new Buyerbo();
            Sellerso ss = new Sellerso();
            //Categories cat = new Categories();
            // SubCategory subcat = new SubCategory();

            Console.WriteLine("1.Buyer\n2.Seller\nEnter your choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("a.Sign in\nb.Register\nEnter choice");
                    string ch1 = Console.ReadLine();
                    switch (ch1)
                    {
                        case "a":
                            Console.WriteLine("Enter Id :");
                            bid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Buyer Password:");
                            bpswd = Console.ReadLine();
                            bool x = bb.signin(bid, bpswd);
                            if (x == true)
                                Console.WriteLine("Id's are matched");
                            else
                                Console.WriteLine("Id's are not matched");
                            break;

                        case "b":
                            Console.WriteLine("Enter Id :");
                            bid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Buyer Name:");
                            bname = Console.ReadLine();
                            Console.WriteLine("Enter Your Password:");
                            bpswd = Console.ReadLine();
                            Console.WriteLine("Enter Email Id:");
                            bmail = Console.ReadLine();
                            Console.WriteLine("Enter Mobile Number:");
                            bno = int.Parse(Console.ReadLine());
                            Console.WriteLine(bb.Register(bid, bname, bpswd, bmail, bno));
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                    break;

                //DateTime dt = DateTime.Now;
                //Console.WriteLine("Buyer account cretaed on "+dt.Month+" "+ dt.Day+"  "+ dt.Year);

                //Console.WriteLine("Categories are : \n");
                //cat.DisplayBuyerCat();




                case 2:
                    Console.WriteLine("a.Sign in\nb.Register\nEnter choice");
                    string ch2 = Console.ReadLine();
                    switch (ch2)
                    {
                        case "a":

                            Console.WriteLine("Enter Seller Id :");
                            int sid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Seller Password:");
                            string spswd = Console.ReadLine();
                            bool x = ss.signin(sid, spswd);
                            if (x == true)
                            {
                                Console.WriteLine("Id's are matched");
                                ss.show();
                            }
                            else
                                Console.WriteLine("Id's are not matched");
                            break;

                        case "b":

                            Console.WriteLine("Enter Seller Id:");
                            int seid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Seller Name:");
                            string sname = Console.ReadLine();
                            Console.WriteLine("Enter Your Password:");
                            string pswd = Console.ReadLine();
                            Console.WriteLine("Enter Company Name:");
                            string compname = Console.ReadLine();
                            Console.WriteLine("Enter GSTIN:");
                            string gstin = Console.ReadLine();
                            Console.WriteLine("Enter brief details about your company:");
                            string det = Console.ReadLine();
                            Console.WriteLine("Enter Postal Address of your company:");
                            string sadd = Console.ReadLine();
                            Console.WriteLine("Enter your company website name:");
                            string cweb = Console.ReadLine();
                            Console.WriteLine("Enter Email Id:");
                            string smail = Console.ReadLine();
                            Console.WriteLine("Enter Mobile Number:");
                            int sno = int.Parse(Console.ReadLine());

                            List<Seller> ls = new List<Seller>();
                            Console.WriteLine(ss.Register(seid, sname, pswd, compname, gstin, det, sadd, cweb, smail, sno));


                            ss.show();


                            break;
                    }
                    break;
            }


            Console.ReadKey();
        }

    }
}
