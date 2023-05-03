using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Massarat.Models;

[Index("NormalizedEmail", Name = "EmailIndex")]
public partial class AspNetUser
{
    [Key]
    public string Id { get; set; } = null!;

    public int AccessFailedCount { get; set; }

    [StringLength(256)]
    public string? Branch { get; set; }

    public string? ConcurrencyStamp { get; set; }

    [StringLength(256)]
    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? FullName { get; set; }

    public bool LockoutEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    [StringLength(256)]
    public string? NormalizedEmail { get; set; }

    [StringLength(256)]
    public string? NormalizedUserName { get; set; }

    public string? PasswordHash { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    [StringLength(256)]
    public string? Province { get; set; }

    public string? SecurityStamp { get; set; }

    public bool TwoFactorEnabled { get; set; }

    [StringLength(256)]
    public string? UserName { get; set; }

    [Column("creationDate")]
    public DateTime? CreationDate { get; set; }

    [Column("lastlogin")]
    public DateTime? Lastlogin { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    [InverseProperty("User")]
    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    [InverseProperty("User")]
    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; } = new List<AspNetUserToken>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();
}
