//using System;

//namespace Practicals
//{
//    class Product
//    {
//        int pcode;
//        string pname, mname;
//        public Product(int pcd, String pnm, String mnm)
//        {
//            pcode = pcd;
//            pname = pnm;
//            mname = mnm;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Product Code:= " + pcode);
//            Console.WriteLine("Product Name:= " + pname);
//            Console.WriteLine("Manufacturer Name:= " + mname);
//        }
//    }

//    public class T3_05
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Dafda Priyanka Tarunbhai - 25SOECE13051\n");
//            int n = args.Length;
//            if (n < 3)
//            {
//                Console.WriteLine("Syntax Error");
//                return;
//            }
//            int pcd = Convert.ToInt32(args[0]);
//            String pnm = args[1];
//            String mnm = args[2];
//            Product p = new Product(pcd, pnm, mnm);
//            p.Display();

//            //to run this program, use the command line and provide three arguments:
//            // csc T3_05.cs
//            // T3_05.exe 101 Mouse Dell
//        }
//    }
//}