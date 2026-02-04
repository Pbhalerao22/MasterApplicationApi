using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Table("tbl_api_log")]
public partial class TblApiLog
{
    [Key]
    [Column("sys_code")]
    public int? SysCode { get; set; }

    [Column("api_type")]
    [StringLength(50)]
    public string? ApiType { get; set; }

    [Column("type_")]
    [StringLength(50)]
    public string? Type { get; set; }

    [Column("content_")]
    public string? Content { get; set; }

    [Column("created_on", TypeName = "timestamp without time zone")]
    public DateTime? CreatedOn { get; set; }

    [Column("request_id")]
    [StringLength(100)]
    public string? RequestId { get; set; }
}
