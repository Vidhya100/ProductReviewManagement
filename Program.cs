﻿using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReview
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management using LINQ!\n");

            List<ProductReviewList> productReviewList = Management.GetProductReviews();
            // Management.Display(productReviewList);
            //Management.TopRecords(productReviewList);
            //Management.GetRecordsWithRatingAboveThree(productReviewList);
            // Management.CountOfReview(productReviewList);
            // Management.GetIdAndReview(productReviewList);
            //Management.SkipTop5Records(productReviewList);
            DataTable table = Management.ToDataTable<ProductReviewList>(productReviewList);
            //Management.PrintDataTable(table);
            //Management.RetrieveTrueRecords(table);
            //Management.AverageRating(table);
            Management.RetrieveRecordsWithNiceReview(table);
        }  
    }
}
