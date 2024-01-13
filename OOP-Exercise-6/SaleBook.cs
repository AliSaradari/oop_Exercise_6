namespace LibraryManagement2;

public class SaleBook : Book
{
    public SaleBook(string name) : base(name)
    {
        
    }

    public int SoldCount { get; private set; }
    
    public override void SetPrice(int price)
    {
        if (price > 1000)
        {
            throw new Exception("The price cannot be more than 1000");
        }
        
        base.SetPrice(price);
    }

    public override void SetCount(int count)
    {
        if (count > 100)
        {
            throw new Exception("The count cannot be more than 100");
        }
        base.SetCount(count);
    }

    public void Sold()
    {
        if (Count == 0)
        {
            throw new Exception();
        }

        SoldCount++;
        var newCount = Count;
        SetCount(--newCount);
    }
}