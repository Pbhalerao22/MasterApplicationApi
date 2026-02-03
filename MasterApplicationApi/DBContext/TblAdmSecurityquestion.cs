using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Keyless]
[Table("tbl_adm_securityquestions")]
public partial class TblAdmSecurityquestion
{
    [Column("code")]
    public long? Code { get; set; }

    [Column("question")]
    [StringLength(1000)]
    public string? Question { get; set; }

    [Column("locked")]
    public bool? Locked { get; set; }
}
