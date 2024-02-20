namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBeoDeposit
{
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public string? DepositType { get; set; }
    public decimal? DepositPercentage { get; set; }
    public decimal? DepositAmount { get; set; }
    public DateTime? DepositDate { get; set; }
    public string? DepositDateForm { get; set; }
    public decimal? DepositPaid { get; set; }
    public decimal? DepositSurcharge { get; set; }
    public decimal? DepositRest { get; set; }
    public string? DepositDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBeoDeposit>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BEO_DEPOSIT");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositAmount)
                .HasColumnName("DEPOSIT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositDate)
                .HasColumnName("DEPOSIT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepositDateForm)
                .HasColumnName("DEPOSIT_DATE_FORM")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.DepositDescription)
                .HasColumnName("DEPOSIT_DESCRIPTION")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.DepositPaid)
                .HasColumnName("DEPOSIT_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositPercentage)
                .HasColumnName("DEPOSIT_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositRest)
                .HasColumnName("DEPOSIT_REST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositSurcharge)
                .HasColumnName("DEPOSIT_SURCHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositType)
                .HasColumnName("DEPOSIT_TYPE")
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
