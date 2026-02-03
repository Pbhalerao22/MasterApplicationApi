using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Keyless]
[Table("tbl_adm_usermaster")]
public partial class TblAdmUsermaster
{
    [Column("code")]
    public long? Code { get; set; }

    [Column("username")]
    [StringLength(50)]
    public string? Username { get; set; }

    [Column("password")]
    [StringLength(500)]
    public string? Password { get; set; }

    [Column("fullname")]
    [StringLength(500)]
    public string? Fullname { get; set; }

    [Column("mobileno")]
    [StringLength(12)]
    public string? Mobileno { get; set; }

    [Column("gender")]
    public long? Gender { get; set; }

    [Column("dob")]
    [StringLength(200)]
    public string? Dob { get; set; }

    [Column("bloodgroup")]
    [StringLength(5)]
    public string? Bloodgroup { get; set; }

    [Column("imagename")]
    [StringLength(50)]
    public string? Imagename { get; set; }

    [Column("experiencelevel")]
    public long? Experiencelevel { get; set; }

    [Column("isaduser")]
    public bool? Isaduser { get; set; }

    [Column("isadmin")]
    public bool? Isadmin { get; set; }

    [Column("locked")]
    public bool? Locked { get; set; }

    [Column("loginattempts")]
    public long? Loginattempts { get; set; }

    [Column("createiondate", TypeName = "timestamp without time zone")]
    public DateTime? Createiondate { get; set; }

    [Column("createdby")]
    public long? Createdby { get; set; }

    [Column("lastmodificationdate")]
    [StringLength(200)]
    public string? Lastmodificationdate { get; set; }

    [Column("lastmodifiedby")]
    public long? Lastmodifiedby { get; set; }

    [Column("securityquestion")]
    public long? Securityquestion { get; set; }

    [Column("securityanswer")]
    [StringLength(2000)]
    public string? Securityanswer { get; set; }

    [Column("designation")]
    public long? Designation { get; set; }

    [Column("doj")]
    [StringLength(200)]
    public string? Doj { get; set; }

    [Column("isedit")]
    [StringLength(1)]
    public string? Isedit { get; set; }

    [Column("isdelete")]
    [StringLength(1)]
    public string? Isdelete { get; set; }

    [Column("csf_sys_code")]
    public long? CsfSysCode { get; set; }

    [Column("login_attempt")]
    [StringLength(10)]
    public string? LoginAttempt { get; set; }
}
