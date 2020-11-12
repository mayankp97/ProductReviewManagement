using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void Top3Records(List<ProductReview> listProductReview)
        {
            var recordedData = (from ProductReviews in listProductReview
                                orderby ProductReviews.Rating descending
                                select ProductReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID);
            }
        }
        public void SpecificRecords(List<ProductReview> listProductReview)
        {
            var recordData = from productReviews in listProductReview
                             where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                             && productReviews.Rating > 3
                             select productReviews;
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.ProductID);
            }
        }
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordData)
            {
                Console.WriteLine((list.ProductID) + "\t" + list.Count);
            }
        }
        public void RetrieveProductIdAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               select new
                               {
                                   productReviews.ProductID,
                                   productReviews.Review
                               };
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product Id:- " + list.ProductID + "\t" + "Review: " + list.Review);
            }
        }
        public void RetrieveProductsBySkippingTop5(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                select productReviews).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + "UserId: " + list.UserID + "Rating: " + list.Rating
                    + "Review: " + list.Review + "IsLike: " + list.IsLike);
            }
        }
    }
}
