namespace BagIt.Models;

public class UserShoppingList
{
    public int ListId { get; set; }
    public ShoppingList List { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}