namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConResvShareRef
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string ResIdType { get; set; }
    public string ResIdValue { get; set; }
    public string ResvIdSource { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConResvShareRef>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_RESV_SHARE_REF");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResIdType)
                .HasColumnName("RES_ID_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResIdValue)
                .HasColumnName("RES_ID_VALUE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvIdSource)
                .HasColumnName("RESV_ID_SOURCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
