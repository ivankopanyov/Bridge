namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EvoucherDeliveryView
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? VoucherId { get; set; }
    public decimal? VoucherNo { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? VoucherAmount { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string? Room { get; set; }
    public string? GuestTitle { get; set; }
    public string? CompanyName { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestLanguage { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? Validity { get; set; }
    public decimal? MaxVouchersPerCheck { get; set; }
    public DateTime? VoucherDate { get; set; }
    public DateTime? ValidUntilDate { get; set; }
    public string? RemainingAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EvoucherDeliveryView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVOUCHER_DELIVERY_VIEW");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestLanguage)
                .HasColumnName("GUEST_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestTitle)
                .HasColumnName("GUEST_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MaxVouchersPerCheck)
                .HasColumnName("MAX_VOUCHERS_PER_CHECK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RemainingAmount)
                .HasColumnName("REMAINING_AMOUNT")
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

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.ValidUntilDate)
                .HasColumnName("VALID_UNTIL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Validity)
                .HasColumnName("VALIDITY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.VoucherAmount)
                .HasColumnName("VOUCHER_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.VoucherDate)
                .HasColumnName("VOUCHER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VoucherId)
                .HasColumnName("VOUCHER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VoucherNo)
                .HasColumnName("VOUCHER_NO")
                .HasColumnType("NUMBER");
        });
	}
}
