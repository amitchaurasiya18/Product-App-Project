using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Product
    {
        private int _productId;
        private string _productName;
        private double _productPrice;
        private double _productDiscountPercentage;
        public const int MAXIMUM_DISCOUNT = 100;

        public Product(int productId, string productName, double productPrice, double productDiscountPercentage)
        {
            _productDiscountPercentage = productDiscountPercentage;
            _productId = productId;
            _productName = productName;
            _productPrice = productPrice;
        }

        public double CalculateDiscount(double productPrice)
        {
            double discount;
            discount = productPrice - (productPrice * (_productDiscountPercentage / MAXIMUM_DISCOUNT));
            return discount;
        }

        public string PrintProductDetails()
        {
            return $"Product Id: {_productId}\nProduct Name: {_productName}\nProduct's Actual Price: {_productPrice}\nProduct's Discounted Price: {CalculateDiscount(_productPrice)}\nYou got {_productDiscountPercentage}% discount...";
        }

        public int GetProductId()
        {
            return _productId;
        }

        public string GetProductName()
        {
            return _productName;
        }

        public double GetProductPrice()
        {
            return _productPrice;
        }

        public double GetProductDiscountPercentage()
        {
            return _productDiscountPercentage;
        }
    }
}
