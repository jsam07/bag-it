using System.ComponentModel.DataAnnotations;

namespace BagIt.Models;

public class ShoppingList
{
    [Key]
    public int ListId { get; set; }
    public string? Name { get; set; }
    public string? Notes { get; set; }
    public bool? IsPublic { get; set; }
    public bool? IsEditable { get; set; }
    public string? Description { get; set; }
    
    public List<UserShoppingList> UserShoppingLists { get; set; }
    public List<ShoppingListProduct> ShoppingListProducts { get; set; }
}