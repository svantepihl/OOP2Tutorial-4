using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace OOP2Tutorial_4
{
    public interface ICatalogue
    {
        public event ChangeHandler CatalogueChanged;
        IEnumerable<Product> AllProducts();
        
        void AddProduct(Product p);

        Product FindProduct(string name);

        bool RemoveProduct(string name);

        bool RenameProduct(string name, string newName);

        bool UpdateProductPrice(string name, double price);

        double CalculateSum();
    }
}