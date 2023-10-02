using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Maui.Controls;

namespace DZ4_5
{
    public partial class GoodsPage : ContentPage
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>();

        public GoodsPage(string productName, decimal productPrice, string productDescription)
        {
            InitializeComponent();

            // Use the entered product information as needed
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Retrieve and process the entered goods details (ExpirationDate, Quantity, UnitOfMeasure)
                DateTime expirationDate = DateTime.Parse(ExpirationDateEntry.Text);
                int quantity = int.Parse(QuantityEntry.Text);
                string unitOfMeasure = UnitOfMeasureEntry.Text;

                // Create a new Goods object and add it to the ObservableCollection
                Goods newGoods = new Goods
                {
                    ExpirationDate = expirationDate,
                    Quantity = quantity,
                    UnitOfMeasure = unitOfMeasure
                };

                products.Add(newGoods);

                // Optionally, clear the input fields
                ExpirationDateEntry.Text = string.Empty;
                QuantityEntry.Text = string.Empty;
                UnitOfMeasureEntry.Text = string.Empty;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during data parsing or saving
                DisplayAlert("Error", "An error occurred: " + ex.Message, "OK");
            }
        }


        private void DeleteProduct_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is Goods goods)
            {
                // Remove the selected Goods item from the ObservableCollection
                products.Remove(goods);
            }
        }

        private void DisplayGoods_Clicked(object sender, EventArgs e)
        {
            // Filter the ObservableCollection to display only Goods items
            var goodsCollection = new ObservableCollection<Goods>(products.OfType<Goods>());
            ProductListView.ItemsSource = goodsCollection;
        }
    }
}