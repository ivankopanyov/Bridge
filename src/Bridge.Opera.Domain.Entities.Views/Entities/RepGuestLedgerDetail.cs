namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepGuestLedgerDetail
{
    public decimal? ResvNameId { get; set; }
    public string? ResvStatus { get; set; }
    public string? Arrival { get; set; }
    public string? Departure { get; set; }
    public string? PaymentMethod { get; set; }
    public string? FullName { get; set; }
    public decimal? Persons { get; set; }
    public decimal? ShareAmount { get; set; }
    public string? RateCode { get; set; }
    public string? Room { get; set; }
    public decimal? Credits { get; set; }
    public decimal? Fixed { get; set; }
    public decimal? Extras { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepGuestLedgerDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_GUEST_LEDGER_DETAIL");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Extras)
                .HasColumnName("EXTRAS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Fixed)
                .HasColumnName("FIXED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
