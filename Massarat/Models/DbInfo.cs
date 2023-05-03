using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Massarat.Models;

[Keyless]
[Table("dbInfo")]
public partial class DbInfo
{
    [Column("id")]
    public int Id { get; set; }

    [Column("lastDbupdate")]
    [StringLength(151)]
    public string? LastDbupdate { get; set; }
}
