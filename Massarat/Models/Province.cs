using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Massarat.Models;

[Table("province")]
public partial class Province
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    [Column("ProvinceID")]
    public int ProvinceId { get; set; }
}
