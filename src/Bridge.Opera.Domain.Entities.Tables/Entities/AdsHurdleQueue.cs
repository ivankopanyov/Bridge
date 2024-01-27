namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AdsHurdleQueue
{
    public decimal ActionId { get; set; }
    public string Resort { get; set; }
    public DateTime HurdleDate { get; set; }
    public string RoomCategory { get; set; }
    public string YieldCategory { get; set; }
    public decimal? Los { get; set; }
    public decimal? Delta { get; set; }
    public decimal? Hurdle { get; set; }
    public string Override { get; set; }
    public decimal? Upsolds { get; set; }
    public decimal? Ceiling { get; set; }
    public decimal? Maxsolds { get; set; }
    public string YmCode { get; set; }
    public string ActionType { get; set; }
    public string Consumer { get; set; }
    public decimal? BeActionId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AdsHurdleQueue>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("ADS_HURDLE_QUEUE_PK");

            entity.ToTable("ADS_HURDLE_QUEUE");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeActionId)
                .HasColumnName("BE_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ceiling)
                .HasColumnName("CEILING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Consumer)
                .HasColumnName("CONSUMER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Delta)
                .HasColumnName("DELTA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Hurdle)
                .HasColumnName("HURDLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HurdleDate)
                .HasColumnName("HURDLE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Maxsolds)
                .HasColumnName("MAXSOLDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Override)
                .HasColumnName("OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Upsolds)
                .HasColumnName("UPSOLDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YmCode)
                .HasColumnName("YM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
