using System;
using System.Collections;

namespace ClassLibrary1
{
    public class Book
    {
        string bookName, bookAuthor, bookId, bookType;
        int bookCopy;
        static int c = 0;
        static int countBook=0;
        //static ArrayList list = new ArrayList();
        //sting[] a = new string[5];
        string[,] uu = new string[c,5];
        //static int arrayListLength;
        public Book()
        { }

        public Book(string bookname, string bookauthor, string bookid, string booktype, int bookcopy)
        {
            this.bookName = bookname;
            this.bookAuthor = bookauthor;
            this.bookId = bookid;
            this.bookType = booktype;
            this.bookCopy = bookcopy;
            Book.countBook += bookcopy;
            /*uu[c, 0] = bookname;
            uu[c, 1] = bookauthor;
            uu[c, 2] = bookid;
            uu[c, 3] = booktype;
            uu[c, 4] = bookcopy.ToString();*/

            /*for (int j = 0; j < uu.Count; j++)
            {
                arrayListLength++;
            }*/
            c++;

        }
        public string BookName
        {
            set { this.bookName = value; }
            get { return bookName; }
        }
        public string BookAuthor
        {
            set { this.bookAuthor = value; }
            get { return bookAuthor; }
        }
        public string BookId
        {
            set{this.bookId=value;}
            get{return bookId;}
        }
        public string BookType
        {
            set { this.bookType = value; }
            get { return bookType;}
        }
        public int BookCopy
        {
            set { this.bookCopy = value; Book.countBook += value; }
            get { return bookCopy; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Name: " + bookName);
            Console.WriteLine("Book Author: " + bookAuthor);
            Console.WriteLine("Book ID : " + bookId);
            Console.WriteLine("Book Type: " + bookType);
            Console.WriteLine("Book Copy: " + bookCopy);
        }
        public void AddBookCopy(int a)
        {
            this.bookCopy += a;
            Book.countBook += a;
            Console.WriteLine("Book Copy Is Increased. New Book Copy Is " + bookCopy);
        }
        public static void ShowTotalBookInfo()
        {
            /*for (int u = 0; u < uu.Length; u++)
            {
                Console.WriteLine("The New Book Start Here: \n");
                for (int v = 0; v < 5; v++)
                {
                    string g =uu[u,v];
                    Console.WriteLine(g);
                }
                Console.WriteLine("\nThe Book End Here.");               
            }*/
            Console.WriteLine("Total Book Is: " + countBook);
        }
    }
}
