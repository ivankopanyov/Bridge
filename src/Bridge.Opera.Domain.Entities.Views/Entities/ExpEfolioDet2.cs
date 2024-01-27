namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEfolioDet2
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public string ExportType { get; set; }
    public string TrxCode { get; set; }
    public string TrxDesc { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Gad { get; set; }
    public decimal? TaxAmount { get; set; }
    public DateTime? HInsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEfolioDet2>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EFOLIO_DET2");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Gad)
                .HasColumnName("GAD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HInsertDate)
                .HasColumnName("H_INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
