namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SampleVoucherVw
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal GuestNameId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string ArrivalDateIso { get; set; }
    public string DepartureDateIso { get; set; }
    public string Room { get; set; }
    public decimal? VoucherAmount { get; set; }
    public string VoucherAmountWords { get; set; }
    public string FullName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SampleVoucherVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SAMPLE_VOUCHER_VW");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalDateIso)
                .HasColumnName("ARRIVAL_DATE_ISO")
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureDateIso)
                .HasColumnName("DEPARTURE_DATE_ISO")
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VoucherAmount)
                .HasColumnName("VOUCHER_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VoucherAmountWords)
                .HasColumnName("VOUCHER_AMOUNT_WORDS")
                .IsUnicode(false);
        });
	}
}
