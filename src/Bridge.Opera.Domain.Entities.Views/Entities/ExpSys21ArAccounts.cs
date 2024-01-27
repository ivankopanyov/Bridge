namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21ArAccounts
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? AgeBucket1Balance { get; set; }
    public decimal? AgeBucket2Balance { get; set; }
    public decimal? AgeBucket3Balance { get; set; }
    public decimal? AgeBucket4Balance { get; set; }
    public decimal? AgeBucket5Balance { get; set; }
    public decimal? AgeBucket6Balance { get; set; }
    public decimal? TotalBalance { get; set; }
    public string AccountNo { get; set; }
    public string AccountType { get; set; }
    public string AccountTypeDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21ArAccounts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_AR_ACCOUNTS");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeDesc)
                .HasColumnName("ACCOUNT_TYPE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AgeBucket1Balance)
                .HasColumnName("AGE_BUCKET_1_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket2Balance)
                .HasColumnName("AGE_BUCKET_2_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket3Balance)
                .HasColumnName("AGE_BUCKET_3_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket4Balance)
                .HasColumnName("AGE_BUCKET_4_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket5Balance)
                .HasColumnName("AGE_BUCKET_5_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket6Balance)
                .HasColumnName("AGE_BUCKET_6_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBalance)
                .HasColumnName("TOTAL_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
