using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Keyless]
[Table("usp_tbl_adm_exceptionlog")]
public partial class UspTblAdmExceptionlog
{
    [Column("code")]
    public long? Code { get; set; }

    [Column("usercode")]
    public long? Usercode { get; set; }

    [Column("machinename")]
    [StringLength(50)]
    public string? Machinename { get; set; }

    [Column("url")]
    [StringLength(500)]
    public string? Url { get; set; }

    [Column("exceptiondetails")]
    public string? Exceptiondetails { get; set; }

    [Column("logdate", TypeName = "timestamp without time zone")]
    public DateTime? Logdate { get; set; }
}
