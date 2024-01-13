using OOP_Exercise_6;

namespace LibraryManagement2;

public class Library : Interface1
{
    //private static List<Category> _categories = new();
    private static List<Book> _books = new();
    //private static List<User> _users = new();

    public void AddBook(string name,int type,int count,int price)
    {
        if (type == 1)
        {
            var saleBook = new SaleBook(name);
            saleBook.SetCount(count);
            saleBook.SetPrice(price);
            _books.Add(saleBook);
        }

        if (type == 2)
        {
            var rentBook = new RentBook(name);
            rentBook.SetPrice(price);
            rentBook.SetCount(count);
            _books.Add(rentBook);
        }
    }


    public void RemoveBook(string bookName)
    {
        var book = _books.Find(_=>_.Name == bookName);
        _books.Remove(book);
    }

    public void ShowBookDetail()
    {
        foreach (var book in _books)
        {
            Console.WriteLine($"Book Name: {book.Name} Book Count: {book.Count} Book Price: {book.Price}");
        }
    }
}