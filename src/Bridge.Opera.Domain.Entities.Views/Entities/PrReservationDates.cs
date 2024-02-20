namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PrReservationDates
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string? NameType { get; set; }
    public string? ContactYn { get; set; }
    public DateTime? ProfileBeginDate { get; set; }
    public DateTime? ProfileEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PrReservationDates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PR_RESERVATION_DATES");

            entity.Property(e => e.ContactYn)
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfileBeginDate)
                .HasColumnName("PROFILE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProfileEndDate)
                .HasColumnName("PROFILE_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
