namespace strip.Model;

public class ProductEntity
{
    public int Id { get; set; }
    public string? Product { get; set; }
    public int Rate { get; set; }
    public int Quantity { get; set; }
    public string? ImagePath { get; set; }
}