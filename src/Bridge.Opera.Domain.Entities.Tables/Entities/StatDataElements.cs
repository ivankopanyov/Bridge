namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StatDataElements
{
    public decimal? ActionInstanceId { get; set; }
    public string? ActionType { get; set; }
    public string? DataElement { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public DateTime? ScopeFrom { get; set; }
    public DateTime? ScopeTo { get; set; }
    public decimal? RaDataElementId { get; set; }
    public string? StatsProcessedYn { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StatDataElements>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAT_DATA_ELEMENTS");

            entity.HasIndex(e => e.ActionInstanceId)
                .HasName("SDA_IND1");

            entity.HasIndex(e => new { e.InsertDate, e.DataElement })
                .HasName("SDA_IND2");

            entity.HasIndex(e => new { e.BusinessDate, e.Resort, e.DataElement })
                .HasName("SDA_IND3");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.DataElement })
                .HasName("SDA_IND4");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DataElement)
                .IsRequired()
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RaDataElementId)
                .HasColumnName("RA_DATA_ELEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScopeFrom)
                .HasColumnName("SCOPE_FROM")
                .HasColumnType("DATE");

            entity.Property(e => e.ScopeTo)
                .HasColumnName("SCOPE_TO")
                .HasColumnType("DATE");

            entity.Property(e => e.StatsProcessedYn)
                .HasColumnName("STATS_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
