namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RevenueTypesDetails1
{
    public string RevType { get; set; }
    public string Resort { get; set; }
    public decimal? Vat { get; set; }
    public string ContributeMinRevenueYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RevenueTypesDetails1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REVENUE_TYPES_DETAILS");

            entity.Property(e => e.ContributeMinRevenueYn)
                .HasColumnName("CONTRIBUTE_MIN_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Vat)
                .HasColumnName("VAT")
                .HasColumnType("NUMBER");
        });
	}
}
