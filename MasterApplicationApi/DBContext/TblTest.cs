using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

[Table("TBL_TEST")]
public partial class TblTest
{
    [Key]
    [Column("CODE")]
    public int Code { get; set; }

    [Column("NAME")]
    public int? Name { get; set; }
}
