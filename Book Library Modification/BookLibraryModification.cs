using Book_Library;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;


var input = File.ReadAllLines("input.txt");
var library = new Library()
{
    Name = "Selekta",
    Books = new List<Book>()
};

var currentLine = 1;

var booksCount = int.Parse(input[0]);

for (int i = 0; i < booksCount; i++)
{
    var tokens = input.Skip(currentLine++).First().Split();

    var title = tokens[0];
    var author = tokens[1];
    var publisher = tokens[2];
    var releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
    var isbn = tokens[4];
    var price = decimal.Parse(tokens[5]);


    var book = new Book(title, author, publisher, releaseDate, isbn, price);

    library.Books.Add(book);
}
var date = DateTime.ParseExact(input.Skip(currentLine++).First(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

var filterBooks = library.Books.Where(b => b.ReleaseDate > date).OrderBy(a => a.ReleaseDate).ThenBy(a => a.Title).ToArray();

File.Delete("output.txt");
using (var writer = File.AppendText("output.txt"))
{
    foreach (var book in filterBooks)
    {
   
        writer.WriteLine($"{book.Title} ->{book.ReleaseDate:dd.MM.yyyy}");
    }
   
}
;


namespace Book_Library
{
    class AuthorInfo
    {
        public string Author { get; set; }

        public decimal Sales { get; set; }
    }

    class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }

    }
    class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}