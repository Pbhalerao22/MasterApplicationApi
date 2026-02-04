using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Table("tbl_adm_forgetpassword")]
public partial class TblAdmForgetpassword
{
    [Key]
    [Column("code")]
    public long? Code { get; set; }

    [Column("userid")]
    public long? Userid { get; set; }

    [Column("securityquestion")]
    public long? Securityquestion { get; set; }

    [Column("securityanswer")]
    [StringLength(2000)]
    public string? Securityanswer { get; set; }

    [Column("creationdate", TypeName = "timestamp without time zone")]
    public DateTime? Creationdate { get; set; }

    [Column("createdby")]
    public long? Createdby { get; set; }
}
