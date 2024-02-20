namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArAgingsummTypeOpen
{
    public string? AccountType { get; set; }
    public string? TypeDesc { get; set; }
    public decimal? AccountTypeId { get; set; }
    public string? AgeRange { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public decimal? AgeSeq { get; set; }
    public decimal? AgingAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArAgingsummTypeOpen>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_AGINGSUMM_TYPE_OPEN");

            entity.Property(e => e.AccountType)
                .IsRequired()
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeRange)
                .HasColumnName("AGE_RANGE")
                .IsUnicode(false);

            entity.Property(e => e.AgeSeq)
                .HasColumnName("AGE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgingAmount)
                .HasColumnName("AGING_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TypeDesc)
                .IsRequired()
                .HasColumnName("TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
