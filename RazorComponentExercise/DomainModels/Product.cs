namespace RazorComponentExercise.DomainModels;

public class Product
{
    private static int availableProductId = 1;

    public Product(string productName, int price)
    {
        Id = availableProductId;
        ProductName = productName;
        Price = price;
        availableProductId++;
    }

    public int Id { get; set; }
    public string ProductName { get; set; }
    public int Price { get; set; }
}
