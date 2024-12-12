using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class AppUser: IdentityUser
    {
        [Required]
        public string? FullName { get; set; }
    }
}