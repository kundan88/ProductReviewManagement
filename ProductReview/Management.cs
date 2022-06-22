using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProductReviewManagementWithLinq
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

       public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from ProductReviews in listProductReview
                orderby ProductReviews.Rating descending
                select ProductReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserId:-" + list.UserId
                             + "" + "Rating:-" + list.Rating + "" + "Rewiew:-" + list.Review + "" + "isLike:-" + list.isLike);
            }
        }

     
    }
}
