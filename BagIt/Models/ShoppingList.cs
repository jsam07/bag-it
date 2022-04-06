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

    [System.Text.Json.Serialization.JsonIgnore]
    public List<UserShoppingList> UserShoppingLists { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]
    public List<ShoppingListProduct> ShoppingListProducts { get; set; }
}