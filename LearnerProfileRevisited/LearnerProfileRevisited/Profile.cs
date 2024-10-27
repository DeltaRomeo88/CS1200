public class Profile
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool MarketingOptIn { get; set; }

    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException("Age cannot be negative.");
            age = value;
        }
    }

    private decimal height;
    public decimal Height
    {
        get { return height; }
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException("Height cannot be negative.");
            height = value;
        }
    }

    private decimal weight;
    public decimal Weight
    {
        get { return weight; }
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException("Weight cannot be negative.");
            weight = value;
        }
    }
}