//using System;

//namespace Practicals
//{
//    internal class T2_12
//    {
//        public static void Main(string[] args)
//        {
//            int n,search;
//            int found = 0;
//            Console.Write("Enter total number of Elements:");
//            n = Convert.ToInt32(Console.ReadLine());

//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write("Enter ELements:");
//                arr[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Console.WriteLine("Enter an element to search:");
//            search = Convert.ToInt32(Console.ReadLine());
//            for(int i=0; i < n; i++)
//            {
//                if (arr[i] == search)
//                {
//                    found = 1;
//                    break;
//                }
//                Console.WriteLine(found);
//            }
//        }

//        }
//    }