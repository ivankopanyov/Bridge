namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConStayRevenue
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? RevAmount { get; set; }
    public string RevType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConStayRevenue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_STAY_REVENUE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevAmount)
                .HasColumnName("REV_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
