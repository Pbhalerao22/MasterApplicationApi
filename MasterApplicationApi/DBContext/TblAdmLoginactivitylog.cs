using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Keyless]
[Table("tbl_adm_loginactivitylog")]
public partial class TblAdmLoginactivitylog
{
    [Column("code")]
    public long? Code { get; set; }

    [Column("usercode")]
    public long? Usercode { get; set; }

    [Column("logindate", TypeName = "timestamp without time zone")]
    public DateTime? Logindate { get; set; }

    [Column("logoutdate", TypeName = "timestamp without time zone")]
    public DateTime? Logoutdate { get; set; }

    [Column("isnormallogout")]
    public bool? Isnormallogout { get; set; }

    [Column("aspsessionid")]
    [StringLength(100)]
    public string? Aspsessionid { get; set; }

    [Column("formname")]
    [StringLength(100)]
    public string? Formname { get; set; }

    [Column("formenterdate", TypeName = "timestamp without time zone")]
    public DateTime? Formenterdate { get; set; }

    [Column("isforcelogout")]
    public bool? Isforcelogout { get; set; }

    [Column("loginsession")]
    [StringLength(100)]
    public string? Loginsession { get; set; }
}
