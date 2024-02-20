namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HilifethView
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public decimal? RoomCategory { get; set; }
    public string? Label { get; set; }
    public string? HilifethText { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HilifethView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HILIFETH_VIEW");

            entity.Property(e => e.HilifethText)
                .HasColumnName("HILIFETH_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasColumnType("NUMBER");
        });
	}
}
