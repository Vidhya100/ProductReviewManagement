﻿using System;
using System.Collections.Generic;
namespace ProductReview
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management using LINQ!\n");

            List<ProductReviewList> productReviewList = Management.GetProductReviews();
            Management.Display(productReviewList);
            Management.TopRecords(productReviewList);
        }  
    }
}
