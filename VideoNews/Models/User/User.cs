using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace VideoNews.Models.User;

public class User : IdentityUser
{
    [Key] public override string Id { get; set; } = null!;

    [Column(TypeName = "varchar(255)")] public string? FirstName { get; set; }
    [Column(TypeName = "varchar(255)")] public string? LastName { get; set; }
    [Column(TypeName = "varchar(255)")] public string? MiddleName { get; set; }
}