namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RecalcTaxProgress
{
    public decimal Sid { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal? FolioView { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RecalcTaxProgress>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RECALC_TAX_PROGRESS");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");
        });
	}
}
