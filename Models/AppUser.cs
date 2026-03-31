using System.ComponentModel.DataAnnotations;
using EventManagementSystem.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace EventManagementSystem.Models;

public class AppUser : IdentityUser // Inherit from IdentityUser to include properties like Id, UserName, Email, etc.
{
    [StringLength(100)] // The maximum length of the username is 100 characters
    [MaxLength(100)] // The maximum length of the name is 100 characters
    [Required] // Full name is required and should not exceed 100 characters
    public string? Name { get; set; } // Full name of the user
    
    public string? Address { get; set; } // Address of the user
}