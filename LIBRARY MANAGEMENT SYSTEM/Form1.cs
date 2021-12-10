using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
    public partial class LibraryManagementSystem : Form
    {
        List<USER> users = new List<USER>();
        List<BOOK> books = new List<BOOK>();
        public LibraryManagementSystem()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void AddBookOnClick(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(BookIDTextbox.Text);
            string bookname = BookNameTextBox.Text;
            string author = AuthorTextBox.Text;
            string publisher = PublisherTextbox.Text;
            int quantity = Convert.ToInt32(QuantityTextBox.Text);

            BOOK dummy_book = new BOOK();
            dummy_book.bookid = bookid;
            dummy_book.bookname = bookname;
            dummy_book.author = author;
            dummy_book.publisher = publisher;
            dummy_book.quantity += quantity;
            books.Add(dummy_book);
            MessageBox.Show("Successfully Saved.");
        }

        private void AddUserOnclick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserIDTextBox.Text);
            string name = NameTextBox.Text;
            string Address = AddressTextBox.Text;

            USER dummy_user = new USER();
            dummy_user.userid = id;

            dummy_user.useraddress = Address;
            dummy_user.username = name;
            bool flag = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].userid)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show("User already exists.");
            }
            else
            {
                users.Add(dummy_user);
                MessageBox.Show("Successfully Saved");
            }
        }

        private void BorrowBookOnClick(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(UserIDdTextBox.Text);
            int bookid = Convert.ToInt32(BookIDdTextBox.Text);

            bool user_exists = false;
            bool book_exists = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (userid == users[i].userid)
                {
                    user_exists = true;
                }
            }
            for (int i = 0; i < books.Count; i++)
            {
                if (bookid == books[i].bookid)
                {
                    book_exists = true;
                }
            }
            int borrowed_book;
            if (user_exists == true && book_exists == true)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (bookid == books[i].bookid)
                    {
                        books[i].borrowBook();
                        borrowed_book = books[i].getId();

                    }
                }
                for (int i = 0; i < users.Count; i++)
                {
                    if (userid == users[i].userid)
                    {
                        users[i].borrowBook(bookid);
                        MessageBox.Show("Input Saved.");
                    }

                }

            }
        }


        private void ShowUserOnClick(object sender, EventArgs e)
        {
            ShowHistoryBox.Items.Clear();
            int id = Convert.ToInt32(UserIDddTextBox.Text);
            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].userid)
                {
                    for (int j = 0; j < users[i].borrowedBooks.Count; j++)
                    {
                        for (int k = 0; k < books.Count; k++)
                        {
                            if (users[i].borrowedBooks[j] == books[k].bookid)
                            {
                                ShowHistoryBox.Items.Add(books[k].getBookinfo());
                            }
                        }
                    }
                }
            }
        }

        private void showBookHistoryOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookIDdddTextBox.Text);
            for (int k = 0; k < books.Count; k++)
            {
                if (id == books[k].bookid)
                {
                    QuantityyLabel.Text = "Quantity : " + Convert.ToString(books[k].quantity);
                    IDLabel.Text = "ID : " + Convert.ToString(books[k].bookid);
                    NameeLabel.Text = "Name : " + books[k].bookname;
                    PublisherrLabel.Text = "Publisher: " + books[k].publisher;
                    AuthorrLabel.Text = "Author : " + books[k].author;
                }
            }
        }
    }
}
