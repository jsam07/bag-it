using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BagIt.Models;


public class User 
{
    [Key]
    public int UserId { get; set; }
    
    [DisplayName("Username")]
    [MaxLength(70, ErrorMessage="Username must be 70 characters or less")]
    public string? Username { get; set; }
    
    [DisplayName("Email")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    [Required(ErrorMessage = "Email address is required")]
    public string Email { get; set; }
    
    [DisplayName("First Name")]
    [MaxLength(50, ErrorMessage="First Name must be 50 characters or less")]
    public string? FirstName { get; set; }
    
    [DisplayName("Last Name")]
    [MaxLength(50, ErrorMessage="Last Name must be 50 characters or less")]
    public string? LastName { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; set; }
    public string? Address { get; set; }

    [Phone]
    public string? Phone { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]
    public List<UserShoppingList>? UserShoppingLists { get; set; }
}