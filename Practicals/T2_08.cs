//using System;

//namespace Practicals
//{
//    internal class T2_08
//    {
//        class NumberManipulator
//        {
//            public int getValues(out int x, out int y, out int z)
//            {
//                Console.Write("Enter the first value: ");
//                x = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter the second value: ");
//                y = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter the third value: ");
//                z = Convert.ToInt32(Console.ReadLine());

//                int sum = x + y + z;
//                return sum;
//            }
//        }

//        class TestOut
//        {
//            static void Main(string[] args)
//            {
//                NumberManipulator n = new NumberManipulator();
//                int a, b, c, sum;

//                sum = n.getValues(out a, out b, out c);

//                Console.WriteLine("After method call, value of a : {0}", a);
//                Console.WriteLine("After method call, value of b : {0}", b);
//                Console.WriteLine("After method call, value of c : {0}", c);
//                Console.WriteLine("Sum : {0}", sum);
//            }
//        }
//    }
//}