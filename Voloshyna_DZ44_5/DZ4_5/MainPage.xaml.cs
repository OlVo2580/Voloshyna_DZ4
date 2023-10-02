using Microsoft.Maui.Controls;
namespace DZ4_5
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BooksButton_Clicked(object sender, EventArgs e)
        {
            // Navigate to the BooksPage and pass the entered data
            await Navigation.PushAsync(new BooksPage(
                ProductNameEntry.Text,
                decimal.Parse(ProductPriceEntry.Text),
                ProductDescriptionEntry.Text));
        }

        private async void GoodsButton_Clicked(object sender, EventArgs e)
        {
            // Navigate to the GoodsPage and pass the entered data
            await Navigation.PushAsync(new GoodsPage(
                ProductNameEntry.Text,
                decimal.Parse(ProductPriceEntry.Text),
                ProductDescriptionEntry.Text));
        }



    }
}