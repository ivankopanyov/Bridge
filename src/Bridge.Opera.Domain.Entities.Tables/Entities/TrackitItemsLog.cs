namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrackitItemsLog
{
    public decimal? TrackitLogId { get; set; }
    public decimal? TrackitId { get; set; }
    public string? ChangeType { get; set; }
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public string? OrigValue { get; set; }
    public string? NewValue { get; set; }
    public string? Machine { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrackitItemsLog>(entity =>
        {
            entity.HasKey(e => e.TrackitLogId)
                .HasName("TRACKIT_ITEMS_LOG_PK");

            entity.ToTable("TRACKIT_ITEMS_LOG");

            entity.HasIndex(e => e.InsertDate)
                .HasName("TRACKIT_INSERT_DT_IDX");

            entity.HasIndex(e => new { e.TrackitId, e.ChangeType })
                .HasName("TRACKIT_ID_IDX");

            entity.HasIndex(e => new { e.Resort, e.InsertDate, e.ChangeType })
                .HasName("TRACKIT_INS_DATE_IDX");

            entity.HasIndex(e => new { e.ChainCode, e.Resort, e.BusinessDate, e.ChangeType })
                .HasName("TRACKIT_BUS_DATE_IDX");

            entity.Property(e => e.TrackitLogId)
                .HasColumnName("TRACKIT_LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChangeType)
                .IsRequired()
                .HasColumnName("CHANGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OrigValue)
                .HasColumnName("ORIG_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrackitId)
                .HasColumnName("TRACKIT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
