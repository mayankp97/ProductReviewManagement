using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    class LinqDT
    {
        public DataTable AddToDataTableDemo(List<ProductReview> listProductReviews)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductId", typeof(int));
            table.Columns.Add("UserId", typeof(int));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));

            foreach (ProductReview product in listProductReviews)
            {
                table.Rows.Add(product.ProductID, product.UserID, product.Rating, product.Review, product.IsLike);
            }
            return table;
        }
        public void RetrieveRecords(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    Console.Write(row[column] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void GetAverageRating(DataTable table)
        {
            var recordedData = from products in table.AsEnumerable()
                               group products by products.Field<int>("ProductId") into g
                               select new { ProductId = g.Key, Average = g.Average(a => a.Field<double>("Rating")) };
            foreach (var row in recordedData)
            {
                Console.Write(row.ProductId + "\t" + row.Average + "\n");
            }
        }
    }
}
