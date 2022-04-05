using System.ComponentModel.DataAnnotations;

namespace BagIt.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string Name { get; set; }

    public bool IsAddedToList { get; set; } = false;
    public string? Icon { get; set; }
    public int? Quantity { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    
    [System.Text.Json.Serialization.JsonIgnore]
    public List<ShoppingListProduct> ShoppingListProducts { get; set; }

}