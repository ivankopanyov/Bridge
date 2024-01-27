namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArAgingSummaryType
{
    public string AccountType { get; set; }
    public string Style { get; set; }
    public string TypeDesc { get; set; }
    public decimal? AccountTypeId { get; set; }
    public decimal? Aging1 { get; set; }
    public decimal? Aging2 { get; set; }
    public decimal? Aging3 { get; set; }
    public decimal? Aging4 { get; set; }
    public decimal? Aging5 { get; set; }
    public decimal? Aging6 { get; set; }
    public decimal? AgeTotal { get; set; }
    public decimal? AgePercent { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArAgingSummaryType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_AGING_SUMMARY_TYPE");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgePercent)
                .HasColumnName("AGE_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeTotal)
                .HasColumnName("AGE_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging1)
                .HasColumnName("AGING1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging2)
                .HasColumnName("AGING2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging3)
                .HasColumnName("AGING3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging4)
                .HasColumnName("AGING4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging5)
                .HasColumnName("AGING5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging6)
                .HasColumnName("AGING6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Style)
                .HasColumnName("STYLE")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.TypeDesc)
                .HasColumnName("TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
