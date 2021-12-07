using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKSTOREMANAGEMENTSYSTEM
{
    public partial class BookstoreManagementSystem : Form
    {
        List<STUDYBOOK> StudyBooks = new List<STUDYBOOK>();
        List<RESEARCHARTICLE> ResearchArticles = new List<RESEARCHARTICLE>();
        public BookstoreManagementSystem()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddStudyBookOnClick(object sender, EventArgs e)
        {
            string id = BookIdTextBox.Text;
            string title = BookTitleTextBox.Text;
            string author = BookAuthorTextBox.Text;
            string publisher = BookPublisherTextBox.Text;
            int quantity = Convert.ToInt32(BookQuantityTextBox.Text);
            string isbn = BookISBNTextBox.Text;
            string genre = BookGenreTextBox.Text;

            STUDYBOOK dummyStudyBook = new STUDYBOOK();
            dummyStudyBook.BookId = id;

            dummyStudyBook.BookName = title;
            dummyStudyBook.BookAuthor = author;
            dummyStudyBook.BookPublisher = publisher;
            dummyStudyBook.BookQuantity += quantity;
            dummyStudyBook.BookISBN = isbn;
            dummyStudyBook.BookGenre = genre;


            StudyBooks.Add(dummyStudyBook);
            MessageBox.Show("Study Book Saved!");
        }

        private void AddResearchArticleOnClick(object sender, EventArgs e)
        {
            string id = ResearchIdTextBox.Text;
            string title = ResearchTitleTextBox.Text;
            string author = ResearchAuthorTextBox.Text;
            string publisher = ResearchPublisherTextBox.Text;
            int quantity = Convert.ToInt32(ResearchArticleQuantityTextBox.Text);
            string doi = ResearchArticleDOITextBox.Text;
            string date = Convert.ToString(ResearchArticlePublishedDateTextBox.Text);
            string ConferenceOrJournal = CJTextBox.Text;

            RESEARCHARTICLE dummyResearchArticle = new RESEARCHARTICLE();
            dummyResearchArticle.BookId = id;

            dummyResearchArticle.BookName = title;
            dummyResearchArticle.BookAuthor = author;
            dummyResearchArticle.BookPublisher = publisher;
            dummyResearchArticle.BookQuantity += quantity;
            dummyResearchArticle.ArticleDoi = doi;
            dummyResearchArticle.PublishedDate = date;
            dummyResearchArticle.ConferenceOrJournal = ConferenceOrJournal;


            ResearchArticles.Add(dummyResearchArticle);
            MessageBox.Show("Research Article Saved!");
        }

        private void BorrowBookOnClick(object sender, EventArgs e)
        {
            string id = BorrowBookIDTextBox.Text;
            for (int i = 0; i < StudyBooks.Count; i++)
            {
                if (id == StudyBooks[i].BookId)
                {
                    StudyBooks[i].borrow();
                    MessageBox.Show("Study Book Borrowed!");

                }
            }
        }

        private void BorrowArticleOnCLick(object sender, EventArgs e)
        {
            string id = BorrowArticleIdTextBox.Text;
            for (int i = 0; i < ResearchArticles.Count; i++)
            {
                if (id == ResearchArticles[i].BookId)
                {
                    ResearchArticles[i].borrow();
                    MessageBox.Show("Research Article Borrowed!");

                }
            }
        }

        private void ShowStudyBookOnClick(object sender, EventArgs e)
        {
            BookList.Items.Clear();
            for (int i = 0; i < StudyBooks.Count; i++)
            {

                BookList.Items.Add(StudyBooks[i].getInfo());


            }
        }

        private void ShowArticlesOnClick(object sender, EventArgs e)
        {
            ArticlesList.Items.Clear();
            for (int i = 0; i < ResearchArticles.Count; i++)
            {

                ArticlesList.Items.Add(ResearchArticles[i].getInfo());


            }
        }
    }
}
