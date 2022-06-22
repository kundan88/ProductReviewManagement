using System;
using System.Linq;
using System.Data;
namespace ProductReviewManagementWithLinq
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management statement");


            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 2, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 2, Rating = 3, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 3, Rating = 4, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 6, UserId = 4, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 5, Rating = 1, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 2, Rating =6, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 11, UserId = 6, Rating = 4, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 12, UserId = 6, Rating = 4, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 14, UserId = 7, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 15, UserId = 8, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 13, UserId = 10, Rating = 3, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 16, UserId = 12, Rating = 5, Review = "Nice", isLike = true },


        };

            

           Management management = new Management();
           management.TopRecords(productReviewList);

        }



    }

}