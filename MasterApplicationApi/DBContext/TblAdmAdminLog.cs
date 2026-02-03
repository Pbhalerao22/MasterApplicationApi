using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Table("tbl_adm_admin_logs")]
public partial class TblAdmAdminLog
{
    [Key]
    [Column("admin_log_id")]
    public long AdminLogId { get; set; }

    [Column("user_code")]
    public long? UserCode { get; set; }

    [Column("user_name")]
    [StringLength(100)]
    public string? UserName { get; set; }

    [Column("action_time", TypeName = "timestamp without time zone")]
    public DateTime? ActionTime { get; set; }

    [Column("action_type")]
    [StringLength(50)]
    public string? ActionType { get; set; }

    [Column("target_user_code")]
    public long? TargetUserCode { get; set; }

    [Column("target_user_name")]
    [StringLength(100)]
    public string? TargetUserName { get; set; }

    [Column("action_details")]
    [StringLength(500)]
    public string? ActionDetails { get; set; }

    [Column("ip_address")]
    [StringLength(45)]
    public string? IpAddress { get; set; }

    [Column("login_session_id")]
    [StringLength(100)]
    public string? LoginSessionId { get; set; }
}
