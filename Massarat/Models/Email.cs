using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Massarat.Models;

[Keyless]
[Table("email")]
public partial class Email
{
    [Column("seq")]
    public double? Seq { get; set; }

    [Column("email")]
    [StringLength(255)]
    public string? Email1 { get; set; }
}
