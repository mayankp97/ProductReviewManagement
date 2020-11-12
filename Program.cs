using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        public static List<ProductReview> productReviewList;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            InitializeList();
            var management = new Management();
            //management.Top3Records(productReviewList);
            //management.SpecificRecords(productReviewList);
            //management.RetrieveCountOfRecords(productReviewList);
            //management.RetrieveProductIdAndReview(productReviewList);
            //management.RetrieveProductsWithNiceMessage(productReviewList);
            var linqDT = new LinqDT();
            management.dataTable = linqDT.AddToDataTableDemo(productReviewList);
            //linqDT.RetrieveRecords(management.dataTable);
            //linqDT.GetAverageRating(management.dataTable);
            linqDT.RetrieveOrderedProductsByRating(1, management.dataTable);
        }

        public static void InitializeList()
        {
            productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",IsLike=true},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=4,UserID=10,Rating=6,Review="Good",IsLike=false},
                new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="nice",IsLike=true},
                new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="bas",IsLike=true},
                new ProductReview(){ProductID=8,UserID=1,Rating=1,Review="Good",IsLike=false},
                new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="nice",IsLike=true},
                new ProductReview(){ProductID=2,UserID=10,Rating=10,Review="nice",IsLike=true},
                new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="nice",IsLike=true},
                new ProductReview(){ProductID=11,UserID=1,Rating=3,Review="nice",IsLike=true},
                new ProductReview() { ProductID = 11, UserID = 4, Rating = 3, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 8, UserID = 3, Rating = 5, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 9, UserID = 4, Rating = 2, Review = "bad", IsLike = false },
                new ProductReview() { ProductID = 2, UserID = 5, Rating = 7, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 4, UserID = 8, Rating = 3, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 11, UserID = 3, Rating = 6, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 7, UserID = 5, Rating = 8, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 6, UserID = 10, Rating = 7, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 4, UserID = 3, Rating = 7, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 9, UserID = 2, Rating = 4, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 3, UserID = 7, Rating = 6, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 1, UserID = 10, Rating = 8, Review = "nice", IsLike = false },
                new ProductReview() { ProductID = 8, UserID = 10, Rating = 9, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 5, UserID = 10, Rating = 4, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 10, UserID = 1, Rating = 7, Review = "nice", IsLike = true },

            };
        }
    }
}
