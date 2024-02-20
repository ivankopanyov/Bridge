namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsAvhUpdateView
{
    public string? Host { get; set; }
    public string? Resort { get; set; }
    public string? Chain { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? RoomType { get; set; }
    public string? RateCode { get; set; }
    public string? ActCode { get; set; }
    public decimal? Nights { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAvhUpdateView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_AVH_UPDATE_VIEW");

            entity.Property(e => e.ActCode)
                .HasColumnName("ACT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Chain)
                .HasColumnName("CHAIN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Host)
                .HasColumnName("HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
