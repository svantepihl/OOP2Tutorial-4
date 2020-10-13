using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace OOP2Tutorial_4
{
    public partial class Form1 : Form
    {
        private Catalogue catalogue = new Catalogue();
        
        public Form1()
        {
            InitializeComponent();
            catalogue.CatalogueChanged += CatalogueOnCatalogueChanged;
            
        }

        private void CatalogueOnCatalogueChanged(object sender, Catalogue.ChangeHandlerArgs args)
        {
            CatalogueListBox.Items.Clear();
            foreach (Product p in catalogue.AllProducts())
            {
                CatalogueListBox.Items.Add(p);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = NameTextBox.Text;
            p.Price = Double.Parse(PriceTextBox.Text);
            catalogue.AddProduct(p);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Product tmp = CatalogueListBox.SelectedItem as Product;
            if (tmp != null)
            {
                {catalogue.RemoveProduct(tmp.Name);}
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            Product tmp = CatalogueListBox.SelectedItem as Product;
            if (tmp != null)
            {
                catalogue.RenameProduct(tmp.Name, NameTextBox.Text);
            }
        }

        private void RepriceButton_Click(object sender, EventArgs e)
        {
            Product tmp = CatalogueListBox.SelectedItem as Product;
            if (tmp != null)
            {
                catalogue.UpdateProductPrice(tmp.Name, double.Parse(PriceTextBox.Text));
            }
        }
    }
}