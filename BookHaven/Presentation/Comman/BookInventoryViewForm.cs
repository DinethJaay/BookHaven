using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.BookManagementRepository;
using BookHaven.Presentation.Admin;

namespace BookHaven.Presentation.Comman
{
    public partial class BookInventoryViewForm : Form
    {
        private readonly BookRepository _bookRepository;
        public BookInventoryViewForm()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadBooks(string searchparm)
        {
            try
            {
                var books = _bookRepository.GetAllBooks(searchparm);
                dataGridView1.DataSource = books;

                dataGridView1.Columns["IsDeleted"].Visible = false;
                dataGridView1.Columns["CreatedAt"].Visible = false;
                dataGridView1.Columns["UpdatedAt"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookInventoryViewForm_Load(object sender, EventArgs e)
        {
            LoadBooks(string.Empty);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtsearch.Text.Trim();
            LoadBooks(searchTerm); // Load the books filtered by the search term
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtTitle.Text = selectedRow.Cells["Title"].Value.ToString();
                txtAuthor.Text = selectedRow.Cells["Author"].Value.ToString();
                txtIsbn.Text = selectedRow.Cells["ISBN"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["StockQuantity"].Value.ToString();
                txtCategory.Text = selectedRow.Cells["Genre"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the BookId from the selected row
                int bookId = (int)selectedRow.Cells["BookId"].Value;

                // Create a Book object with the updated data from the text boxes
                Book updatedBook = new Book
                {
                    BookId = bookId,
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    ISBN = txtIsbn.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    StockQuantity = int.Parse(txtQuantity.Text),
                    Genre = txtCategory.Text
                };

                // Update the book in the repository/database
                var result = _bookRepository.EditBook(updatedBook);

                if (result)
                {
                    MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks(txtsearch.Text.Trim()); // Load the books filtered by the search term
                }
                else
                {
                    MessageBox.Show("Failed to update the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the BookId of the selected book
                int bookId = (int)selectedRow.Cells["BookId"].Value;

                // Ask for confirmation before deleting
                var result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Call the DeleteBook method to delete the book from the database
                    var success = _bookRepository.DeleteBook(bookId);

                    if (success)
                    {
                        MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBooks(txtsearch.Text.Trim()); // Refresh the grid to show the updated list of books
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }
    }
}
