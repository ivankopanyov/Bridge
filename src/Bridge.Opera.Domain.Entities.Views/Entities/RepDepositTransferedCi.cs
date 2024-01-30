namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepDepositTransferedCi
{
    public string? Arrival { get; set; }
    public string? Departure { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string? FullName { get; set; }
    public string? Room { get; set; }
    public DateTime? PaidDate { get; set; }
    public decimal? AmountAsked { get; set; }
    public decimal? AmountPaid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepDepositTransferedCi>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_DEPOSIT_TRANSFERED_CI");

            entity.Property(e => e.AmountAsked)
                .HasColumnName("AMOUNT_ASKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountPaid)
                .HasColumnName("AMOUNT_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.PaidDate)
                .HasColumnName("PAID_DATE")
                .HasColumnType("DATE");

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
        });
	}
}
