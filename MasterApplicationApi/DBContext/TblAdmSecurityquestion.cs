using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Table("tbl_adm_securityquestions")]
public partial class TblAdmSecurityquestion
{
    [Key]
    [Column("code")]
    public long? Code { get; set; }

    [Column("question")]
    [StringLength(1000)]
    public string? Question { get; set; }

    [Column("locked")]
    public bool? Locked { get; set; }
}
