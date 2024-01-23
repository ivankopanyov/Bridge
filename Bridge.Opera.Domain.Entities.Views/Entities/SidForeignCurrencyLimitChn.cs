namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidForeignCurrencyLimitChn
{
    public string ChainCode { get; set; }
    public string CurrencyCode { get; set; }
    public string LocalYn { get; set; }
    public decimal? DailyLimit { get; set; }
    public decimal? MonthlyLimit { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidForeignCurrencyLimitChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_FOREIGN_CURRENCY_LIMIT_CHN");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DailyLimit)
                .HasColumnName("DAILY_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalYn)
                .IsRequired()
                .HasColumnName("LOCAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MonthlyLimit)
                .HasColumnName("MONTHLY_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
