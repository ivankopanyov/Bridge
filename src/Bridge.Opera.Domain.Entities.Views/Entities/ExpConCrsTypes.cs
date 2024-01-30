namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConCrsTypes
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string? CrsType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConCrsTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_CRS_TYPES");

            entity.Property(e => e.CrsType)
                .HasColumnName("CRS_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
