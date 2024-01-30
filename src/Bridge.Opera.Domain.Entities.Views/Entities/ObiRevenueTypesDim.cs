namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRevenueTypesDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? RevType { get; set; }
    public string? Description { get; set; }
    public string? RevGroup { get; set; }
    public decimal? OrderBy { get; set; }
    public string? FbClass { get; set; }
    public decimal? Vat { get; set; }
    public string? ContributeToMinRevenue { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRevenueTypesDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_REVENUE_TYPES_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ContributeToMinRevenue)
                .HasColumnName("CONTRIBUTE_TO_MIN_REVENUE")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.FbClass)
                .HasColumnName("FB_CLASS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Vat)
                .HasColumnName("VAT")
                .HasColumnType("NUMBER");
        });
	}
}
