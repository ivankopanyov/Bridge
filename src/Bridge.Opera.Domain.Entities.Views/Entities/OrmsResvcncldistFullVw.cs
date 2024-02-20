namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsResvcncldistFullVw
{
    public string? Resort { get; set; }
    public string? ResvCnclFlag { get; set; }
    public DateTime? TruncArrivalDate { get; set; }
    public decimal? LeadDay { get; set; }
    public decimal? BookingClassId { get; set; }
    public string? Dowseason { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsResvcncldistFullVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_RESVCNCLDIST_FULL_VW");

            entity.Property(e => e.BookingClassId)
                .HasColumnName("BOOKING_CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dowseason)
                .IsRequired()
                .HasColumnName("DOWSEASON")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.LeadDay)
                .HasColumnName("LEAD_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvCnclFlag)
                .HasColumnName("RESV_CNCL_FLAG")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.TruncArrivalDate)
                .HasColumnName("TRUNC_ARRIVAL_DATE")
                .HasColumnType("DATE");
        });
	}
}
