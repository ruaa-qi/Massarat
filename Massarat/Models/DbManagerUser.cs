using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Massarat.Models;

[Keyless]
[Table("dbManagerUsers")]
public partial class DbManagerUser
{
    [Column("id")]
    public int Id { get; set; }

    [Column("userName")]
    [StringLength(50)]
    public string? UserName { get; set; }

    [Column("password")]
    [StringLength(50)]
    public string? Password { get; set; }

    [Column("lastLogin")]
    [StringLength(50)]
    public string? LastLogin { get; set; }

    [Column("role")]
    [StringLength(50)]
    public string? Role { get; set; }
}
