using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OOP2Tutorial_4
{
    public class PersistentCatalogue
    {
        private string filename;
        
        private List<Product> _products = new List<Product>();

        public PersistentCatalogue(string filename)
        {
            this.filename = filename;
        }

        public event ChangeHandler CatalogueChanged;
        
        public delegate void ChangeHandler(object sender, ChangeHandlerArgs args);
        
        public class ChangeHandlerArgs
        {
        }

        private void ReadProductsFromFile()
        {
            if (File.Exists(filename))
            {
                string fileContents = File.ReadAllText(filename);
                _products = JsonSerializer.Deserialize<List<Product>>(fileContents);
            }
            else
            {
                _products = new List<Product>();
            }
        }

        private void WriteProductsToFile()
        {
            string contents = JsonSerializer.Serialize(_products);
            File.WriteAllText(filename,contents);
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
    }
}