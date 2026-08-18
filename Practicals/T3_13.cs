using System;

namespace Practicals
{
    class ProductDetails
    {
        public int prodId { get; set; }
        public string prodName { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public double CalculatedBill() {
            return price * quantity;
        }
        public void Display()
        {
            Console.WriteLine("-----Product Details-----");
            Console.WriteLine("Product id is " + prodId);
            Console.WriteLine("Product Name is " + prodName);
            Console.WriteLine("Product Price is "+ price);
            Console.WriteLine("Product Quantity is "+  quantity);
            Console.WriteLine("Bill Amount is " + CalculatedBill());
        }
    }
    class T3_13
    {
        public static void T3_13Main()
        {
            ProductDetails p1 = new ProductDetails();

            Console.Write("Enter product id:");
            p1.prodId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter product name:");
            p1.prodName = Console.ReadLine();

            Console.Write("Enter product price:");
            p1.price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter product quantity:");
            p1.quantity= Convert.ToInt32(Console.ReadLine());

            p1.Display();
        }
    }
}