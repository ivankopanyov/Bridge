namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArAgingView
{
    public string Resort { get; set; }
    public string AgingStyle { get; set; }
    public decimal? AccountCode { get; set; }
    public string AccountType { get; set; }
    public decimal? AccountTypeId { get; set; }
    public string AccountName { get; set; }
    public decimal? FromAge { get; set; }
    public decimal? ToAge { get; set; }
    public string AgeRange { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public decimal? Bal { get; set; }
    public decimal? Paybal { get; set; }
    public decimal? SeqNo { get; set; }
    public decimal? RemSeqNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArAgingView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_AGING_VIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeRange)
                .HasColumnName("AGE_RANGE")
                .IsUnicode(false);

            entity.Property(e => e.AgingStyle)
                .HasColumnName("AGING_STYLE")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Bal)
                .HasColumnName("BAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromAge)
                .HasColumnName("FROM_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Paybal)
                .HasColumnName("PAYBAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RemSeqNo)
                .HasColumnName("REM_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToAge)
                .HasColumnName("TO_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE");
        });
	}
}
