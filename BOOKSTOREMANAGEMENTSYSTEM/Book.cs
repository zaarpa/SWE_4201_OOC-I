using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKSTOREMANAGEMENTSYSTEM
{
    internal class Book
    {
        public string BookId;
        public string BookName;
        public string BookAuthor;
        public string BookPublisher;
        public int BookQuantity;

        public void borrow()
        {
            BookQuantity--; 
        }
    }
    class STUDYBOOK : Book
    {
        public string BookISBN;
        public string BookGenre;
        public string getInfo()
        {
            string showBook = BookId + " " + BookName + " " + BookAuthor + " " + BookISBN + " " + Convert.ToString(BookQuantity);
            return showBook;
        }
    }
    class RESEARCHARTICLE : Book
    {
        public string ArticleDoi;
        public string PublishedDate;
        public string ConferenceOrJournal;
        public string getInfo()
        {
            string showArticle = BookId + " " + BookName + " " + BookAuthor + " " + ArticleDoi + " " + Convert.ToString(BookQuantity) + " " + ConferenceOrJournal;
            return showArticle;
        }
    }

}
