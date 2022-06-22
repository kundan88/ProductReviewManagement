using System;
namespace Product_Review_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management");

            ProductReviewManagement productReview = new ProductReviewManagement();
            productReview.CreateDataTable();
            productReview.DisplayList();
        }
    }
}

