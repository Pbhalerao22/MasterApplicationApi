using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Keyless]
[Table("tbl_adm_menumaster")]
public partial class TblAdmMenumaster
{
    [Column("code")]
    public long? Code { get; set; }

    [Column("menuname")]
    [StringLength(100)]
    public string? Menuname { get; set; }

    [Column("menudesc")]
    [StringLength(500)]
    public string? Menudesc { get; set; }

    [Column("parentid")]
    public long? Parentid { get; set; }

    [Column("menuurl")]
    [StringLength(1000)]
    public string? Menuurl { get; set; }

    [Column("menuicon")]
    [StringLength(50)]
    public string? Menuicon { get; set; }

    [Column("menusrno")]
    public long? Menusrno { get; set; }

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

    [Column("isadminmenu")]
    public bool? Isadminmenu { get; set; }

    [Column("areaname")]
    [StringLength(50)]
    public string? Areaname { get; set; }

    [Column("controllername")]
    [StringLength(50)]
    public string? Controllername { get; set; }

    [Column("actionname")]
    [StringLength(50)]
    public string? Actionname { get; set; }
}
