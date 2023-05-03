using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Massarat.Models;

[Table("allUsers")]
public partial class AllUser
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(250)]
    public string? LoginName { get; set; }

    [StringLength(250)]
    public string? LoginPass { get; set; }

    [Column("fullName")]
    [StringLength(250)]
    public string? FullName { get; set; }

    [Column("note")]
    [StringLength(250)]
    public string? Note { get; set; }

    [StringLength(250)]
    public string? Branch { get; set; }

    [StringLength(250)]
    public string? Province { get; set; }
}
