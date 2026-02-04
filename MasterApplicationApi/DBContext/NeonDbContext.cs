using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MasterApplicationApi.DBContext;

public partial class NeonDbContext : DbContext
{
    public NeonDbContext()
    {
    }

    public NeonDbContext(DbContextOptions<NeonDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAdmAdminLog> TblAdmAdminLogs { get; set; }

    public virtual DbSet<TblAdmFileExtMapping> TblAdmFileExtMappings { get; set; }

    public virtual DbSet<TblAdmForgetpassword> TblAdmForgetpasswords { get; set; }

    public virtual DbSet<TblAdmLoginactivitylog> TblAdmLoginactivitylogs { get; set; }

    public virtual DbSet<TblAdmMenumaster> TblAdmMenumasters { get; set; }

    public virtual DbSet<TblAdmRolemaster> TblAdmRolemasters { get; set; }

    public virtual DbSet<TblAdmRolemenumapping> TblAdmRolemenumappings { get; set; }

    public virtual DbSet<TblAdmSecurityquestion> TblAdmSecurityquestions { get; set; }

    public virtual DbSet<TblAdmUsermaster> TblAdmUsermasters { get; set; }

    public virtual DbSet<TblAdmUserrolemapping> TblAdmUserrolemappings { get; set; }

    public virtual DbSet<TblApiLog> TblApiLogs { get; set; }

    public virtual DbSet<TblTest> TblTests { get; set; }

    public virtual DbSet<UspTblAdmExceptionlog> UspTblAdmExceptionlogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=ep-long-tree-ah1cnih6-pooler.c-3.us-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_0qkwpRTYjW2A;SSL Mode=Require;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAdmAdminLog>(entity =>
        {
            entity.HasKey(e => e.AdminLogId).HasName("tbl_adm_admin_logs_pkey");

            entity.Property(e => e.AdminLogId).ValueGeneratedNever();
            entity.Property(e => e.ActionTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        modelBuilder.Entity<TblAdmFileExtMapping>(entity =>
        {
            entity.Property(e => e.SysCreatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        modelBuilder.Entity<TblApiLog>(entity =>
        {
            entity.Property(e => e.CreatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        modelBuilder.Entity<TblTest>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("TBL_TEST_pkey");

            entity.Property(e => e.Code).UseIdentityAlwaysColumn();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
