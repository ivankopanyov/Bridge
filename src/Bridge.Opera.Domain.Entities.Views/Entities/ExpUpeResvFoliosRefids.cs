namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeResvFoliosRefids
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? OrderBy { get; set; }
    public string? FolioId { get; set; }
    public string? ReferenceIdType { get; set; }
    public string? ReferenceId { get; set; }
    public string? ReferenceIdContext { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeResvFoliosRefids>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_RESV_FOLIOS_REFIDS");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioId)
                .HasColumnName("FOLIO_ID")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReferenceId)
                .HasColumnName("REFERENCE_ID")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReferenceIdContext)
                .HasColumnName("REFERENCE_ID_CONTEXT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReferenceIdType)
                .HasColumnName("REFERENCE_ID_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
