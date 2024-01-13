
using LibraryManagement2;


while (true)
{
    try
    {
        Run();
    }
    catch (Exception ex)
    {
        ShowError(ex.Message);
    }
}


static void Run()
{
    var library = new Library();
    int menu = GetInt("1. Add Book\n" +
                      "2. Show Books\n" +
                      "3. Remove Book\n" +
                      "0. Exit");

    switch (menu)
    {
        case 0:
            {
                Environment.Exit(0);
                break;
            }
        case 1:
            {
                var bookName = GetString("Enter Book Name:");
                var bookType = GetInt("1.Sale Book 2.Rent Book");
                var bookCount = GetInt("Enter Book Count:");
                var bookPrice = GetInt("Enter Book Price");
                library.AddBook(bookName, bookType, bookCount, bookPrice);
                break;

            }
        case 2:
            {
                library.ShowBookDetail();
                break;
            }
        case 3:
            {
                var bookName = GetString("Enter Book Name To Remove it");
                library.RemoveBook(bookName);
                break;
            }
    }
}

static string GetString(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    return value;
}

static int GetInt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine()!);
    return value;
}
static void ShowError(string error)
{
    Console.WriteLine("-------------------");
    Console.WriteLine(error);
    Console.WriteLine("-------------------");
}