using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MoneyMaker.Models;

public class ApplicationUser : IdentityUser
{
    [MaxLength(50)]
    public string? DisplayName { get; set; }
}