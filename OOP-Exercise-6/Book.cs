namespace LibraryManagement2;

public abstract class Book
{
    private string _name;
    protected Book(string name)
    {
        Name = name;
    }
    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Name Cannot Be Empty");
            }
            _name = value;
        }
    }
    public int Price { get; private set; }
    public int Count { get; private set; }

    public virtual void SetPrice(int price)
    {
        if (price < 0)
        {
            throw new Exception("The price cannot be less than zero");
        }

        Price = price;
    }

    public virtual void SetCount(int count)
    {
        if (count < 0)
        {
            throw new Exception("The count cannot be less than zero");
        }

        Count = count;
    }
}