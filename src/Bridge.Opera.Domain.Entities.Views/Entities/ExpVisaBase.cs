namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpVisaBase
{
    public decimal? ExpDataId { get; set; }
    public decimal? ExpViewId { get; set; }
    public string? MultiPropertyYn { get; set; }
    public string? Resort { get; set; }
    public decimal? NoOfInvoices { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpVisaBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_VISA_BASE");

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpViewId)
                .HasColumnName("EXP_VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiPropertyYn)
                .IsRequired()
                .HasColumnName("MULTI_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoOfInvoices)
                .HasColumnName("NO_OF_INVOICES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
