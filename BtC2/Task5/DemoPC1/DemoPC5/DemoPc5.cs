namespace Company
{
    class Product
    {
        static void Main(string[] args)
        {
            Object objProductID;
            object objProductName = "";
            object objPrice;
            object objQuantity;

            Console.Write("Enter the id of product : ");
            objProductID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter price : ");
            objPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity : ");
            objQuantity = Convert.ToInt32(Console.ReadLine());

            int ProductID = (int)objProductID;
            string ProductName = (string)objProductName;
            double Price = (double)objPrice;
            int Quantity = (int)objQuantity;
            double amtPayable = (int)objQuantity * Price;

            Console.WriteLine("\nProduct Details:");
            Console.WriteLine("Product ID : " + ProductID);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Price : $" + objPrice);
            Console.WriteLine("Quantity : " + objQuantity);
            Console.WriteLine("Amt Payable {0:F2}: ", amtPayable);
            

        }
    }
}