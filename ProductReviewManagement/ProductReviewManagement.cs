using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    public class ProductReviewManagement
    {
        public List<ProductReview> ProductReviewsList = new List<ProductReview>();
        DataTable productdt;

        // UC 1: Adding a Productreview details
        public int AddProductReview()
        {
            ProductReviewsList.Add(new ProductReview() { ProductID = 1, UserID = 1, Rating = 1, Review = "good", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 5, UserID = 1, Rating = 1, Review = "Average", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 3, UserID = 2, Rating = 1, Review = "good", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 4, UserID = 2, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 5, UserID = 3, Rating = 2, Review = "Average", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 5, UserID = 3, Rating = 2, Review = "good", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 2, UserID = 4, Rating = 3, Review = "bad", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 7, UserID = 4, Rating = 3, Review = "good", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 9, UserID = 5, Rating = 3, Review = "bad", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 10, UserID = 5, Rating = 4, Review = "good", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 10, UserID = 6, Rating = 4, Review = "nice", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 1, UserID = 6, Rating = 4, Review = "bad", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 10, UserID = 7, Rating = 5, Review = "good", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 1, UserID = 7, Rating = 5, Review = "Bad", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 4, UserID = 8, Rating = 5, Review = "good", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 12, UserID = 8, Rating = 1, Review = "good", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 20, UserID = 12, Rating = 4, Review = "good", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 10, UserID = 5, Rating = 4, Review = "good", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 10, UserID = 6, Rating = 4, Review = "nice", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 1, UserID = 6, Rating = 4, Review = "bad", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 10, UserID = 7, Rating = 5, Review = "good", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 1, UserID = 7, Rating = 5, Review = "Bad", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 4, UserID = 8, Rating = 5, Review = "good", IsLike = false });
            ProductReviewsList.Add(new ProductReview() { ProductID = 12, UserID = 8, Rating = 1, Review = "good", IsLike = true });
            ProductReviewsList.Add(new ProductReview() { ProductID = 20, UserID = 12, Rating = 4, Review = "good", IsLike = true });

            return ProductReviewsList.Count;
        }
        public void DisplayList()
        {
            foreach (ProductReview product in ProductReviewsList)
            {
                Console.WriteLine("ProductId: {0} : UserId: {1} : Review: {2} : Rating: {3} : IsLike:{4}\n", product.ProductID, product.UserID, product.Review, product.Rating, product.IsLike);
            }
        }
    }
}

