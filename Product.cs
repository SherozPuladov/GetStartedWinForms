namespace GetStartedWinForms;

public class Product
{
    public int ProductID { get; set; }
    public string? Name { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
}
