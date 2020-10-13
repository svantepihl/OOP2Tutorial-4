using System;
using System.Collections.Generic;

namespace OOP2Tutorial_4
{
    public class Catalogue
    {
        private List<Product> _products = new List<Product>();

        public event ChangeHandler CatalogueChanged;
        
        public delegate void ChangeHandler(object sender, ChangeHandlerArgs args);
        
        public class ChangeHandlerArgs
        {
        }

        public IEnumerable<Product> AllProducts()
        {
            return _products;
        }

        public void AddProduct(Product p)
        {
            _products.Add(p);
            CatalogueChanged?.Invoke(this, new ChangeHandlerArgs());
        }

        public Product FindProduct(string name)
        {
            return _products.Find(product => product.Name.Equals(name));
        }

        public bool RemoveProduct(string name)
        {
            if (_products.Remove(_products.Find(product => product.Name.Equals(name))))
            {
                CatalogueChanged?.Invoke(this, new ChangeHandlerArgs());
                return true;
            }

            return false;
        }

        public bool RenameProduct(string oldName, string newName)
        {
            foreach (Product product in _products)
            {
                if (product.Name.Equals(oldName))
                {
                    product.Name = newName;
                    CatalogueChanged?.Invoke(this, new ChangeHandlerArgs());
                    return true;
                }
            }

            return false;
        }

        public bool UpdateProductPrice(string name, double newprice)
        {
            foreach (Product product in _products)
            {
                if (product.Name.Equals(name))
                {
                    product.Price = newprice;
                    CatalogueChanged?.Invoke(this, new ChangeHandlerArgs());
                    return true;
                }
            }

            return false;
        }
    }
}