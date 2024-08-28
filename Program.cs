using System;

namespace GroceryDiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            double originalPrice = 50.00; // Example: $50.00
            int discountPercentage = 20;  // Example: 20%
            string itemName = "Apples";

            // Calculate the final price after applying the discount
            double discountAmount = (originalPrice * discountPercentage) / 100;
            double finalPrice = originalPrice - discountAmount;

            // Output the item details to the console
            Console.WriteLine($"Item Name: {itemName}");
            Console.WriteLine($"Original Price: ${originalPrice:F2}");
            Console.WriteLine($"Discount Percentage: {discountPercentage}%");
            Console.WriteLine($"Final Price after Discount: ${finalPrice:F2}");
        }
    }
}