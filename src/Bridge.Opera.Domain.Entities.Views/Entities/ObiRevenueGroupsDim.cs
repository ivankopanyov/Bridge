namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRevenueGroupsDim
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string RevGroup { get; set; }
    public string Description { get; set; }
    public string Label { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? BiBucket { get; set; }
    public string BiLabel { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRevenueGroupsDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_REVENUE_GROUPS_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.BiBucket)
                .HasColumnName("BI_BUCKET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BiLabel)
                .HasColumnName("BI_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .IsUnicode(false);
        });
	}
}
