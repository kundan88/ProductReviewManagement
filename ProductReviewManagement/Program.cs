namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Review Management");

            ProductReviewManagement productReview = new ProductReviewManagement();
            productReview.AddProductReview();
            productReview.DisplayList();
        }
    }
}