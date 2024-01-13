namespace LibraryManagement2;

public class RentBook : Book
{
    public RentBook(string name) : base(name)
    {
        
    }

    public override void SetPrice(int price)
    {
        if (price > 500)
        {
            throw new Exception("The price cannot be more than 500");
        }
        base.SetPrice(price);
    }

    public override void SetCount(int count)
    {
        if (count > 200)
        {
            throw new Exception("The count cannot be more than 200");
        }
        base.SetCount(count);
    }
}