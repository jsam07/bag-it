namespace BagIt.Models;

public class ShoppingListProduct
{
    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int ListId { get; set; }
    public ShoppingList List { get; set; }
}