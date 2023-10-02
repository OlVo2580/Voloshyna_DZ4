using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace Voloshyna_DZ44_5
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>();

        public MainPage()
        {
            InitializeComponent();

            // Set the ItemSource of the ProductListView to your ObservableCollection
            ProductListView.ItemsSource = products;
        }

        private void AddProduct_Clicked(object sender, EventArgs e)
        {
            // Get the user-entered information from the input fields
            string productName = ProductNameEntry.Text;
            decimal productPrice = decimal.TryParse(ProductPriceEntry.Text, out decimal price) ? price : 0.0m;
            string productDescription = ProductDescriptionEntry.Text;

            // Add a new product to the ObservableCollection
            products.Add(new Product
            {
                Name = productName,
                Price = productPrice,
                Description = productDescription
            });

            // Clear the input fields after adding the product
            ProductNameEntry.Text = string.Empty;
            ProductPriceEntry.Text = string.Empty;
            ProductDescriptionEntry.Text = string.Empty;
        }
        private void DeleteProduct_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is Product product)
            {
                // Remove the selected product from the ObservableCollection
                products.Remove(product);
            }
        }

    }
}
