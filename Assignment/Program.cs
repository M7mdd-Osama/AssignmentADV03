using static System.Reflection.Metadata.BlobBuilder;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
               new Book("453465", "Book1",new string[] { "Mohamed", "Omar"}, DateTime.Now, 24.4m),
               new Book("22323", "Book2",new string[] { "Ahmed", "Ali"}, DateTime.Now, 35m),
               new Book("22323", "Book3",new string[] { "Mahmoud" ,"Mona"}, DateTime.Now, 70m)
            };
            BookFunctionDelegate title = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, title);

            Func<Book, string> authors = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, authors);

            Func<Book, string> isbn = delegate (Book b){return b.ISBN;};
            LibraryEngine.ProcessBooks(books, isbn);

            Func<Book, string> publicationDate = b => b.PublicationDate.ToShortDateString();
            LibraryEngine.ProcessBooks(books, publicationDate);
        }
    }
}
