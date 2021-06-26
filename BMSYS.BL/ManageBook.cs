using BMSYS.DL;
using System;
using System.Collections.Generic;
namespace BMSYS.BL
{
    public class ManageBook
    {
        List<Books> bookList = new List<Books>()
        {
            new Books(22, "The Push: A Novel" , "Ashley Audrain" , new DateTime(2021,6,26)),
            new Books(23, "A Crooked Tree" , "Una Mannion" , new DateTime(2021,6,27)),
            new Books(24, "Life Among the terrain" , "Una Mannion" , new DateTime(2021,6,28)),
        };

        public void ViewBooks()
        {

            foreach (Books item in bookList)
            {
                Console.WriteLine(" ID NO.{0} | BOOK TITLE: {1} , BOOK AUTHOR: {2} , PUBLISHED DATE: {3}", item.ID, item.BookTitle, item.BookAuthor, item.PublisheDate);

            }

        }
        public void AddBooks()
        {
            Console.WriteLine("ADMIN : ADD BOOK:");
            Console.Write("Enter Book ID: ");
            int AddId = int.Parse(Console.ReadLine());
            Console.Write("Enter Book Title: ");
            string AddBookTitle = Console.ReadLine();
            Console.Write("Enter Book Author: ");
            string AddBookAuthor = Console.ReadLine();
            DateTime AddDate = DateTime.Now;

            Console.WriteLine();

            bookList.Add(new Books(AddId, AddBookTitle, AddBookAuthor, AddDate));
            Console.WriteLine("ID NO.{0}", AddId);
            Console.WriteLine("BOOK TITLE: {0}", AddBookTitle);
            Console.WriteLine("BOOK AUTHOR: {0}", AddBookAuthor);
            Console.WriteLine("DATE ADDED: {0}", AddDate);
            Console.WriteLine();
            Console.WriteLine("Successfully Added!");
            Console.WriteLine();

            foreach (Books item in bookList)
            {
                Console.WriteLine("| ID NO.{0} | BOOK TITLE: {1} , BOOK AUTHOR: {2} , PUBLISHED DATE: {3}", item.ID, item.BookTitle, item.BookAuthor, item.PublisheDate);

            }

        }
        public void RemoveBooks()
        {
            Console.WriteLine("ADMIN : REMOVE BOOK:");

            foreach (Books item in bookList)
            {
                Console.WriteLine("INDEX POSITION: {0}| ID NO.{1} | BOOK TITLE: {2} , BOOK AUTHOR: {3} , PUBLISHED DATE: {4}", item.Index, item.ID, item.BookTitle, item.BookAuthor, item.PublisheDate);

            }
            Console.Write("Enter a Index Position: ");
            int removedBook = int.Parse(Console.ReadLine());
            Console.Write("Enter ID NO: ");
            int removedID = int.Parse(Console.ReadLine());
           
            bookList.RemoveAt(removedBook);
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Index Position {0} | ID NO. {1} |Successfully Removed !! ", removedBook,removedID);
            Console.WriteLine();
            foreach (Books item in bookList)
            {
                Console.WriteLine("| ID NO.{0} | BOOK TITLE: {1} , BOOK AUTHOR: {2} , PUBLISHED DATE: {3}", item.ID, item.BookTitle, item.BookAuthor, item.PublisheDate);

            }

        }

    }
}
