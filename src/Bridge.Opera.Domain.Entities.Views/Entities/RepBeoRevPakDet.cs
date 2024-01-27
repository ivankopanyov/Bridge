namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBeoRevPakDet
{
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal EventId { get; set; }
    public DateTime? StartDate { get; set; }
    public string EventType { get; set; }
    public string EventDesc { get; set; }
    public string RevenueType { get; set; }
    public string RevenueDesc { get; set; }
    public decimal? Total { get; set; }
    public decimal? PkgId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBeoRevPakDet>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BEO_REV_PAK_DET");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventDesc)
                .HasColumnName("EVENT_DESC")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueDesc)
                .HasColumnName("REVENUE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Total)
                .HasColumnName("TOTAL")
                .HasColumnType("NUMBER");
        });
	}
}
