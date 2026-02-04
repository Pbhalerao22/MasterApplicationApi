using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Table("tbl_adm_userrolemapping")]
public partial class TblAdmUserrolemapping
{
    [Key]
    [Column("code")]
    public long? Code { get; set; }

    [Column("usercode")]
    public long? Usercode { get; set; }

    [Column("rolecode")]
    public long? Rolecode { get; set; }

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

    [Column("isassigned")]
    public bool? Isassigned { get; set; }

    [Column("defaultrole")]
    public long? Defaultrole { get; set; }
}
