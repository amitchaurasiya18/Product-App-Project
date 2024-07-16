using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Dell Laptop",65000,10),
                new Product(102,"Lenovo Ideapad S5401",80000,15),
                new Product(103,"MacBook Air",56000,5),
                new Product(104,"HP Pavillion",70000,2)
            };

            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Write("Enter the Product ID to check details (or enter 0 to exit): ");
                int inputProductId = int.Parse(Console.ReadLine());

                if (inputProductId == 0)
                {
                    continueProgram = false;
                    break;
                }

                Product selectedProduct = null;

                foreach (Product product in products)
                {
                    if (product.GetProductId() == inputProductId)
                    {
                        selectedProduct = product;
                        break;
                    }
                }

                if (selectedProduct != null)
                {
                    bool continueOperations = true;
                    while (continueOperations)
                    {
                        Console.WriteLine("\nPress 1 for Product Name\nPress 2 for Product's Price\nPress 3 to check discount\nPress 4 for Product's Discounted Price\nPress 5 for Product Details\nPress 6 to Exit");
                        int selectedOperation = int.Parse(Console.ReadLine());

                        switch (selectedOperation)
                        {
                            case 1:
                                Console.WriteLine($"The Product Name : {selectedProduct.GetProductName()}");
                                break;
                            case 2:
                                Console.WriteLine($"The Product Price : {selectedProduct.GetProductPrice()}");
                                break;
                            case 3:
                                Console.WriteLine($"The Discount on Product is : {selectedProduct.GetProductDiscountPercentage()}%");
                                break;
                            case 4:
                                Console.WriteLine($"The Discounted Price of the product is : {selectedProduct.CalculateDiscount(selectedProduct.GetProductPrice())}");
                                break;
                            case 5:
                                Console.WriteLine(selectedProduct.PrintProductDetails());
                                break;
                            case 6:
                                continueOperations = false;
                                break;
                            default:
                                Console.WriteLine("Select Product again...");
                                break;
                        }
                    }
                }
                else
                    Console.WriteLine("Product not found. Please try again.");
            }
        }
    }
}