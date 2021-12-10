using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
    internal class BOOK
    {
        public int bookid;
        public string bookname;
        public string author;
        public string publisher;
        public int quantity; 

        public string getBookinfo()
        {
            string bookinfo = bookid.ToString() + "\t" + bookname;
            return bookinfo; 
        }

        public int getId()
        {
            return bookid;
        }

        public void addBook()
        {
            quantity++;
        }
        public void borrowBook()
        {
            quantity--;
        }

    }
}
