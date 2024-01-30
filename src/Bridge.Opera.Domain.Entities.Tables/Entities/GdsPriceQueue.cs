namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsPriceQueue
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPriceQueue>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode, e.RoomCategory })
                .HasName("GDS_PRICE_Q_PK");

            entity.ToTable("GDS_PRICE_QUEUE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
