using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Keyless]
[Table("tbl_adm_rolemaster")]
public partial class TblAdmRolemaster
{
    [Column("code")]
    public long? Code { get; set; }

    [Column("rolename")]
    [StringLength(50)]
    public string? Rolename { get; set; }

    [Column("roledescription")]
    [StringLength(500)]
    public string? Roledescription { get; set; }

    [Column("locked")]
    public bool? Locked { get; set; }

    [Column("createiondate", TypeName = "timestamp without time zone")]
    public DateTime? Createiondate { get; set; }

    [Column("createdby")]
    public long? Createdby { get; set; }

    [Column("lastmodificationdate")]
    [StringLength(200)]
    public string? Lastmodificationdate { get; set; }

    [Column("lastmodifiedby")]
    public long? Lastmodifiedby { get; set; }
}
