namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BankCurrency
{
    public string? CurrencyCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? AccountId { get; set; }
    public string? Resort { get; set; }
    public string? CurrencyCommissionDefault { get; set; }

    public virtual BankAccount BankAccount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BankCurrency>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AccountId, e.CurrencyCode })
                .HasName("BANK_CURRENCY_PK");

            entity.ToTable("BANK_CURRENCY");

            entity.HasIndex(e => e.CurrencyCode)
                .HasName("BANK_CURRENCY_CUR_CODE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCommissionDefault)
                .HasColumnName("CURRENCY_COMMISSION_DEFAULT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(BankAccount)))
				entity.Ignore(e => e.BankAccount);
			else
	            entity.HasOne(d => d.BankAccount)
	                .WithMany(p => p.BankCurrency)
	                .HasForeignKey(d => new { d.Resort, d.AccountId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ACCOUNT_ID_FK");
        });
	}
}
