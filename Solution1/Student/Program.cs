using System;
using ClassLibrary1;
using ClassLibrary2;
using System.Collections;

namespace AccountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Account acc = new Account();
            Account acc2 = new Account();
            Console.Write("Your Account Name: ");
            acc.Name = Console.ReadLine();
            Console.Write("Your Account ID: ");
            acc.Id = Console.ReadLine();
            Console.Write("Your Account Balance: ");
            acc.Balance = double.Parse(System.Console.ReadLine());
            Console.Write("\n");
            acc.ShowAll();

            Console.Write("\n\nYour Account Name 2nd: ");
            acc2.Name = Console.ReadLine();
            Console.Write("Your Account ID 2nd: ");
            acc2.Id = Console.ReadLine();
            Console.Write("Your Account Balance 2nd: ");
            acc2.Balance = double.Parse(System.Console.ReadLine());
            Console.Write("\n");
            acc2.ShowAll();

            Console.Write("\nType How Much Money You Want To Deposit In Your Account: ");
            acc.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("After Deposit Showing All.");
            acc.ShowAll();
            Console.Write("Type How Much Money You Want To Tranfer Into "+acc2.Name+"'s Account: ");
            acc.Transfer(double.Parse(Console.ReadLine()), acc2);
            Console.WriteLine("\nAfter Transfer Account 1 to Account 2. Showing All.");
            Console.WriteLine("\nAccount 1 Show All.");
            acc.ShowAll();
            Console.WriteLine("\nAccount 2 Show All.");
            acc2.ShowAll();*/

            Book b1 = new Book("Book 1","asif 1","1","Drama",50);
            Book b2 = new Book("Book 2", "asif 2", "2", "Drama", 100);
            Book b3 = new Book("Book 3", "asif 3", "3", "Drama", 150);
            /*Book b4 = new Book("Book 4", "asif 1", "1", "Drama", 50);
            Book b5 = new Book("Book 5", "asif 2", "2", "Drama", 100);
            Book b6 = new Book("Book 6", "asif 3", "3", "Drama", 150);*/
            Console.WriteLine("\nBook 1 Show All.");
            b1.ShowInfo();
            Console.WriteLine("\nBook 2 Show All.");
            b2.ShowInfo();
            Console.WriteLine("\nBook 3 Show All.");
            b3.ShowInfo();
            b2.BookCopy = 500;
            Book.ShowTotalBookInfo();
            b1.AddBookCopy(10);

            Contact a = new Contact();
            /*Console.WriteLine("\n\nType Your Name First: ");
            a.PersionName = Console.ReadLine();
            Console.WriteLine("\nType Your ID: ");
            a.PersionId = Console.ReadLine();
            Console.WriteLine("\nMobile Number: ");
            a.MobileNumber = Console.ReadLine();
            Console.WriteLine("\nYour Age: ");
            a.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nYour Gender (M/F) : ");
            a.Gender = char.Parse(Console.ReadLine());

            a.DectectMobileNumber();*/
            //Console.WriteLine(a.IsValidEmail("mdabuasif@aiub.edu"));

            /*int[] arr = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.WriteLine("\nYour Array Is : "+arr[i]);
            }*/
            /*ArrayList aa = new ArrayList(5);
            aa.Add(33);
            aa.Add(11);
            aa.Add(44);
            aa.Add(22);
            aa.Add(77);
            for (int t = 0; t < aa.Count; t++)
            {
                Console.WriteLine(aa[t]);
            }*/

            
            System.Console.ReadKey();
        }
    }
}
