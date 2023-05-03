using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Massarat.Models;

[Table("UsersList")]
public partial class UsersList
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    public string? FullName { get; set; }

    [Column("lastlogin")]
    [StringLength(70)]
    public string? Lastlogin { get; set; }

    [Column("PAN")]
    public string? Pan { get; set; }

    [Column("role")]
    public string? Role { get; set; }

    public string? UserName { get; set; }

    [Column("branch")]
    public string? Branch { get; set; }

    [Column("province")]
    public string? Province { get; set; }

    [Column("email")]
    public string? Email { get; set; }
}
