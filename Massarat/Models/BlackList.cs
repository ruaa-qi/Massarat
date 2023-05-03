using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Massarat.Models;

[Table("blackList")]
public partial class BlackList
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    public string? Action { get; set; }

    public string? Branch { get; set; }

    [Column("blockDate")]
    public string? BlockDate { get; set; }

    [Column("blockReason")]
    public string? BlockReason { get; set; }

    [Column("blockedFrom")]
    public string? BlockedFrom { get; set; }

    [Column("cardNo")]
    public string? CardNo { get; set; }

    [Column("govID")]
    public string? GovId { get; set; }

    [Column("grantAuthority")]
    public string? GrantAuthority { get; set; }

    [Column("letterNoDate")]
    public string? LetterNoDate { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("province")]
    public string? Province { get; set; }
}
