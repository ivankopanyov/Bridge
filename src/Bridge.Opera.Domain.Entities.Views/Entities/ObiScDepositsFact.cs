namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScDepositsFact
{
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? DepositPercentage { get; set; }
    public string? DepositComments { get; set; }
    public DateTime? DepositDueDate { get; set; }
    public decimal? DepositPaidAmount { get; set; }
    public decimal? DepositRequestAmount { get; set; }
    public string? DepositResort { get; set; }
    public string? DepositRule { get; set; }
    public string? DepositTypeCode { get; set; }
    public string? DepositTypeDesc { get; set; }
    public decimal? DepositUnpaid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScDepositsFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_DEPOSITS_FACT");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositComments)
                .HasColumnName("DEPOSIT_COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.DepositDueDate)
                .HasColumnName("DEPOSIT_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepositPaidAmount)
                .HasColumnName("DEPOSIT_PAID_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositPercentage)
                .HasColumnName("DEPOSIT_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositRequestAmount)
                .HasColumnName("DEPOSIT_REQUEST_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositResort)
                .HasColumnName("DEPOSIT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepositRule)
                .HasColumnName("DEPOSIT_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepositTypeCode)
                .HasColumnName("DEPOSIT_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepositTypeDesc)
                .HasColumnName("DEPOSIT_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DepositUnpaid)
                .HasColumnName("DEPOSIT_UNPAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
