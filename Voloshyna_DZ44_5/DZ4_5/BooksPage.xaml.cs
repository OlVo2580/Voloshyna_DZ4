using Microsoft.Maui.Controls;
using System;

namespace DZ4_5
{
    public partial class BooksPage : ContentPage
    {
        public BooksPage(string productName, decimal productPrice, string productDescription)
        {
            InitializeComponent();

            // Use the entered product information as needed
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            // Retrieve and process the entered book details (NumberOfPages, Publisher, Authors)
            int numberOfPages = int.Parse(NumberOfPagesEntry.Text);
            string publisher = PublisherEntry.Text;
            string authors = AuthorsEntry.Text;

            // Create a new Books object and add it to your ObservableCollection or perform other actions as needed
            Books newBook = new Books
            {
                Name = BookNameEntry.Text,
                Price = decimal.Parse(BookPriceEntry.Text),
                Description = BookDescriptionEntry.Text,
                NumberOfPages = numberOfPages,
                Publisher = publisher,
                Authors = authors.Split(',').Select(author => author.Trim()).ToList()
            };

            // Add the newBook object to your ObservableCollection or perform other actions as needed
            // For example:
            // products.Add(newBook);

            // Optionally, clear the input fields
            BookNameEntry.Text = string.Empty;
            BookPriceEntry.Text = string.Empty;
            BookDescriptionEntry.Text = string.Empty;
            NumberOfPagesEntry.Text = string.Empty;
            PublisherEntry.Text = string.Empty;
            AuthorsEntry.Text = string.Empty;
        }

        private void DeleteBook_Clicked(object sender, EventArgs e)
        {
            // Handle the deletion of a book here
            // You need to implement the logic to remove the selected book from your ObservableCollection
            // For example:
            // if (sender is Button button && button.CommandParameter is Books book)
            // {
            //     products.Remove(book);
            // }
        }
    }
}
