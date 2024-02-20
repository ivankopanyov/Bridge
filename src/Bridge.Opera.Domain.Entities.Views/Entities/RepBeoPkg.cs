namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBeoPkg
{
    public decimal? PkgBookId { get; set; }
    public string? PkgResort { get; set; }
    public decimal? PkgEventId { get; set; }
    public decimal? PkgId { get; set; }
    public string? PkgCode { get; set; }
    public string? PkgName { get; set; }
    public decimal? PkgAttendees { get; set; }
    public decimal? PkgPrice { get; set; }
    public decimal? PkgGuaranteedAttendees { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBeoPkg>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BEO_PKG");

            entity.Property(e => e.PkgAttendees)
                .HasColumnName("PKG_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgBookId)
                .HasColumnName("PKG_BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgCode)
                .HasColumnName("PKG_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PkgEventId)
                .HasColumnName("PKG_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgGuaranteedAttendees)
                .HasColumnName("PKG_GUARANTEED_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgName)
                .HasColumnName("PKG_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PkgPrice)
                .HasColumnName("PKG_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgResort)
                .IsRequired()
                .HasColumnName("PKG_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
