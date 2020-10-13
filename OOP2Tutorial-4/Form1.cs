using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace OOP2Tutorial_4
{
    public partial class Form1 : Form
    {
        private readonly ICatalogue catalogue;
        
        public Form1(ICatalogue catalogue)
        {
            this.catalogue = catalogue;
            InitializeComponent();
            catalogue.CatalogueChanged += CatalogueOnCatalogueChanged;
            UpdateProductList();
        }

        private void UpdateProductList()
        {
            CatalogueListBox.Items.Clear();
            foreach (Product p in catalogue.AllProducts())
            {
                CatalogueListBox.Items.Add(p);
            }
        }

        private void CatalogueOnCatalogueChanged(object sender, ChangeHandlerArgs args)
        {
            UpdateProductList();
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
            if (CatalogueListBox.SelectedItem is Product tmp)
            {
                {catalogue.RemoveProduct(tmp.Name);}
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (CatalogueListBox.SelectedItem is Product tmp)
            {
                catalogue.RenameProduct(tmp.Name, NameTextBox.Text);
            }
        }

        private void RepriceButton_Click(object sender, EventArgs e)
        {
            if (CatalogueListBox.SelectedItem is Product tmp)
            {
                catalogue.UpdateProductPrice(tmp.Name, double.Parse(PriceTextBox.Text));
            }
        }

        private void CheckPriceButton_Click(object sender, EventArgs e)
        {
            if(CatalogueListBox.SelectedItem is Product tmp)
            {
                if (!tmp.ValidatePrice())
                {
                    MessageBox.Show("Price of the product " + tmp.Name + " is not valid.");
                }
                else
                {
                    MessageBox.Show("Price of the product " + tmp.Name + " is valid.");
                }
            }
        }

        private void TotalsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total price of the catalogue is " + catalogue.CalculateSum());
        }
        
    }
}