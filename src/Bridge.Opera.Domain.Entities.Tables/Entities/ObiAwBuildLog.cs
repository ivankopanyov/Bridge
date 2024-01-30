namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiAwBuildLog
{
    public string? SchemaName { get; set; }
    public string? AwName { get; set; }
    public string? CubeName { get; set; }
    public DateTime? SnapshotDate { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? FinishTime { get; set; }
    public string? Status { get; set; }
    public decimal? Loadid { get; set; }
    public string? Comments { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? Attempt { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? Processed { get; set; }
    public decimal? Rejected { get; set; }
    public DateTime? BuildStarted { get; set; }
    public DateTime? BuildCompleted { get; set; }
    public string? DimName { get; set; }
    public string? CleandimYn { get; set; }
    public string? CleanattrYn { get; set; }
    public decimal? BuildLogId { get; set; }
    public string? ResortList { get; set; }
    public string? CmdType { get; set; }
    public string? RebuildYn { get; set; }
    public string? CopyName { get; set; }
    public decimal? ParentBuildLogId { get; set; }
    public string? DropCubeYn { get; set; }
    public string? DropAwYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAwBuildLog>(entity =>
        {
            entity.HasKey(e => new { e.SchemaName, e.AwName, e.CubeName, e.SnapshotDate, e.Attempt })
                .HasName("OBI_AW_BUILD_LOG_PK");

            entity.ToTable("OBI_AW_BUILD_LOG");

            entity.HasIndex(e => e.BuildLogId)
                .HasName("OBI_AW_BUILD_LOG_ID_UK")
                .IsUnique();

            entity.HasIndex(e => e.Loadid)
                .HasName("OBI_AW_BUILD_LOG_IND3");

            entity.HasIndex(e => e.ParentBuildLogId)
                .HasName("OBI_AW_BUILD_LOG_IND4");

            entity.HasIndex(e => e.Status)
                .HasName("OBI_AW_BUILD_LOG_IND2");

            entity.HasIndex(e => new { e.SchemaName, e.AwName, e.Status })
                .HasName("OBI_AW_BUILD_LOG_IND1");

            entity.Property(e => e.SchemaName)
                .HasColumnName("SCHEMA_NAME")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwName)
                .HasColumnName("AW_NAME")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CubeName)
                .HasColumnName("CUBE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SnapshotDate)
                .HasColumnName("SNAPSHOT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Attempt)
                .HasColumnName("ATTEMPT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BuildCompleted)
                .HasColumnName("BUILD_COMPLETED")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BuildLogId)
                .HasColumnName("BUILD_LOG_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BuildStarted)
                .HasColumnName("BUILD_STARTED")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CleanattrYn)
                .HasColumnName("CLEANATTR_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CleandimYn)
                .HasColumnName("CLEANDIM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CmdType)
                .HasColumnName("CMD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CopyName)
                .HasColumnName("COPY_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DimName)
                .HasColumnName("DIM_NAME")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DropAwYn)
                .HasColumnName("DROP_AW_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DropCubeYn)
                .HasColumnName("DROP_CUBE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FinishTime)
                .HasColumnName("FINISH_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Loadid)
                .HasColumnName("LOADID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParentBuildLogId)
                .HasColumnName("PARENT_BUILD_LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Processed)
                .HasColumnName("PROCESSED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RebuildYn)
                .HasColumnName("REBUILD_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rejected)
                .HasColumnName("REJECTED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortList)
                .HasColumnName("RESORT_LIST")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
