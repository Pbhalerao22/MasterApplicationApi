using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Table("tbl_adm_file_ext_mapping")]
public partial class TblAdmFileExtMapping
{
    [Key]
    [Column("syscode")]
    public long? Syscode { get; set; }

    [Column("projectname")]
    [StringLength(100)]
    public string? Projectname { get; set; }

    [Column("keyname")]
    [StringLength(100)]
    public string Keyname { get; set; } = null!;

    [Column("keyvalue")]
    [StringLength(200)]
    public string? Keyvalue { get; set; }

    [Column("sys_created_by")]
    [StringLength(50)]
    public string? SysCreatedBy { get; set; }

    [Column("sys_created_on", TypeName = "timestamp without time zone")]
    public DateTime? SysCreatedOn { get; set; }

    [Column("sys_modified_by")]
    [StringLength(50)]
    public string? SysModifiedBy { get; set; }

    [Column("sys_modified_on", TypeName = "timestamp without time zone")]
    public DateTime? SysModifiedOn { get; set; }
}
