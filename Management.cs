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
    }
}
