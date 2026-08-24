using System;
using System.Collections.Generic;

namespace DSA_Test
{
    public class SearchProduct
    {
        public String ProductName;
        public int ProductId;

        public void AddProduct(
            Dictionary<int, string> map,
            int ProductId,
            String ProductName)
        {
            if (map.ContainsKey(ProductId))
            {
                Console.WriteLine("Key already exists");
                return;
            }

            map.Add(ProductId, ProductName);
            Console.WriteLine("Addition successful");
        }

        public void RemoveProduct(
            Dictionary<int, String> map,
            int ProductId)
        {
            map.Remove(ProductId);
        }

        public String SearchProductById(
            Dictionary<int, string> map,
            int ProductId)
        {
            if (map.ContainsKey(ProductId))
            {
                return map[ProductId];
            }

            return "";
        }

        // New SKU based lookup
        public void AddProduct(
            Dictionary<string, Ecommerce> map,
            Ecommerce product)
        {
            if (map.ContainsKey(product.SKU))
            {
                return;
            }

            map.Add(product.SKU, product);
        }

        public Ecommerce SearchProductBySKU(
            Dictionary<string, Ecommerce> map,
            string sku)
        {
            if (map.ContainsKey(sku))
            {
                return map[sku];
            }

            return null;
        }

        public bool RemoveProductBySKU(
            Dictionary<string, Ecommerce> map,
            string sku)
        {
            return map.Remove(sku);
        }
    }
}