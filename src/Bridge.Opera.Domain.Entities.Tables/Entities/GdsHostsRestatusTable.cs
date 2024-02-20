namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsHostsRestatusTable
{
    public decimal? RestatusId { get; set; }
    public string? RestatusType { get; set; }
    public string? RestatusSubType { get; set; }
    public string? RestatusGdsHost { get; set; }
    public string? RestatusResort { get; set; }
    public string? RestatusGdsRateCode { get; set; }
    public string? RestatusGdsRoomCategory { get; set; }
    public DateTime? RestatusBeginDate { get; set; }
    public DateTime? RestatusEndDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? ExecutionTime { get; set; }
    public DateTime? BeginTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? Result { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? RateTier { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsHostsRestatusTable>(entity =>
        {
            entity.HasKey(e => e.RestatusId)
                .HasName("GDS_HOSTS_RESTATUS_TABLE_PK");

            entity.ToTable("GDS_HOSTS_RESTATUS_TABLE");

            entity.HasIndex(e => e.ExecutionTime)
                .HasName("GDS_HOSTS_RESTATUS_TABL_IND4");

            entity.Property(e => e.RestatusId)
                .HasColumnName("RESTATUS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginTime)
                .HasColumnName("BEGIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ExecutionTime)
                .HasColumnName("EXECUTION_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateTier)
                .HasColumnName("RATE_TIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RestatusBeginDate)
                .HasColumnName("RESTATUS_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RestatusEndDate)
                .HasColumnName("RESTATUS_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RestatusGdsHost)
                .IsRequired()
                .HasColumnName("RESTATUS_GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestatusGdsRateCode)
                .IsRequired()
                .HasColumnName("RESTATUS_GDS_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestatusGdsRoomCategory)
                .IsRequired()
                .HasColumnName("RESTATUS_GDS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestatusResort)
                .IsRequired()
                .HasColumnName("RESTATUS_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestatusSubType)
                .HasColumnName("RESTATUS_SUB_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestatusType)
                .IsRequired()
                .HasColumnName("RESTATUS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Result)
                .HasColumnName("RESULT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
