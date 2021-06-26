using System;

namespace BMSYS.DL
{
    public class Books
    {
        private static object sync = new object();
        private static int indexCount = 0;
        private int index;
        private int id;
        private string bookTitle;
        private string bookAuthor;
        private DateTime publishedDate;
        public  Books(int id, string bookTitle, string bookAuthor , DateTime publishedDate)
        {
            this.id = id;
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;
            this.publishedDate = publishedDate;
            lock (sync)
            {
                this.index = indexCount++;
            }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        

        public  int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string BookTitle
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        public DateTime PublisheDate
        {
            get { return publishedDate; }
            set { publishedDate = value; }
        }

    }
}
