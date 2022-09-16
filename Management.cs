﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReview
{
    class Management
    {
        public static List<ProductReviewList> GetProductReviews()
        {
            List<ProductReviewList> ProductReviewList = new List<ProductReviewList>()
            {
                new ProductReviewList(){ProductId=1,UserId=1,Rating=5,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=2,UserId=1,Rating=4,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=3,UserId=2,Rating=5,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=4,UserId=2,Rating=4,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=5,UserId=3,Rating=2,Review="Good",IsLike=false},
                new ProductReviewList(){ProductId=6,UserId=4,Rating=1,Review="Good",IsLike=false},
                new ProductReviewList(){ProductId=7,UserId=3,Rating=1.5,Review="Good",IsLike=false},
                new ProductReviewList(){ProductId=8,UserId=10,Rating=9,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=9,UserId=10,Rating=10,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=10,UserId=10,Rating=8,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=11,UserId=10,Rating=3,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=12,UserId=10,Rating=7,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=13,UserId=10,Rating=2,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=14,UserId=10,Rating=1,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=15,UserId=10,Rating=6,Review="Good",IsLike=true},
                new ProductReviewList(){ProductId=16,UserId=10,Rating=4,Review="Good",IsLike=true}
            };
            return ProductReviewList;
        }

        public static void Display(List<ProductReviewList> ProductReviewList)
        {
            Console.Write("{0,-20}", "ProductId");
            Console.Write("{0,-20}", "UserId");
            Console.Write("{0,-20}", "Rating");
            Console.Write("{0,-20}", "Review");
            Console.Write("{0,-20}", "IsLike");
            Console.WriteLine();
            foreach (ProductReviewList pr in ProductReviewList)
            {
                Console.Write("{0,-20}", pr.ProductId);
                Console.Write("{0,-20}", pr.UserId);
                Console.Write("{0,-20}", pr.Rating);
                Console.Write("{0,-20}", pr.Review);
                Console.Write("{0,-20}", pr.IsLike);
                Console.WriteLine();
            }
        }

        public static void TopRecords(List<ProductReviewList> ProductReviewList)
        {
            var data = (from list in ProductReviewList
                        orderby list.Rating descending
                        select list).Take(3);
            Console.WriteLine("\nTop 3 Records By Rating:");
            foreach (var pr in data)
            {
                Console.Write("{0,-20}", pr.ProductId);
                Console.Write("{0,-20}", pr.UserId);
                Console.Write("{0,-20}", pr.Rating);
                Console.Write("{0,-20}", pr.Review);
                Console.Write("{0,-20}", pr.IsLike);
                Console.WriteLine();
            }
        }

        public static void GetRecordsWithRatingAboveThree(List<ProductReviewList> productReviewList)
        {
            var records = from list in productReviewList
                          where list.Rating > 3 && (list.ProductId == 1 ||
                                list.ProductId == 4 || list.ProductId == 9)
                          select list;
            Console.WriteLine("\nRecords with rating greater than 3 and productId in (1,4,9):");
            Console.Write("{0,-20}", "ProductId");
            Console.Write("{0,-20}", "UserId");
            Console.Write("{0,-20}", "Rating");
            Console.Write("{0,-20}", "Review");
            Console.Write("{0,-20}", "IsLike");
            Console.WriteLine();
            foreach (var pr in records)
            {
                Console.Write("{0,-20}", pr.ProductId);
                Console.Write("{0,-20}", pr.UserId);
                Console.Write("{0,-20}", pr.Rating);
                Console.Write("{0,-20}", pr.Review);
                Console.Write("{0,-20}", pr.IsLike);
                Console.WriteLine();
            }
        }

        public static void CountOfReview(List<ProductReviewList> productReviewList)
        {
            var records = from list in productReviewList
                          group list by list.ProductId into grp
                          select new
                          {
                              ProductId = grp.Key,
                              NumberOfReviews = grp.Count()
                          };
            Console.WriteLine("\nNo of reviews per product id");
            Console.Write("{0,-20}", "ProductId");
            Console.Write("{0,-20}", "NumberOfReviews");
            Console.WriteLine();
            foreach (var pr in records)
            {
                Console.Write("{0,-20}", pr.ProductId);
                Console.Write("{0,-20}", pr.NumberOfReviews);
                Console.WriteLine();
            }
        }


        public static void GetIdAndReview(List<ProductReviewList> productReviewList)
        {
            var records = from list in productReviewList
                          select new
                          {
                              ProductId = list.ProductId,
                              Review = list.Review
                          };
            Console.WriteLine("\nProductId and Review");
            Console.Write("{0,-20}", "ProductId");
            Console.Write("{0,-20}", "Review");
            Console.WriteLine();
            foreach (var pr in records)
            {
                Console.Write("{0,-20}", pr.ProductId);
                Console.Write("{0,-20}", pr.Review);
                Console.WriteLine();
            }
        }

        public static void SkipTop5Records(List<ProductReviewList> productReviewList)
        {
            var records = (from list in productReviewList
                           select list).Skip(5);
            Console.WriteLine("\nSkip First 5 Records:");
            Console.Write("{0,-20}", "ProductId");
            Console.Write("{0,-20}", "UserId");
            Console.Write("{0,-20}", "Rating");
            Console.Write("{0,-20}", "Review");
            Console.Write("{0,-20}", "IsLike");
            Console.WriteLine();
            foreach (var pr in records)
            {
                Console.Write("{0,-20}", pr.ProductId);
                Console.Write("{0,-20}", pr.UserId);
                Console.Write("{0,-20}", pr.Rating);
                Console.Write("{0,-20}", pr.Review);
                Console.Write("{0,-20}", pr.IsLike);
                Console.WriteLine();
            }
        }
    }
}