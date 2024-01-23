namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FtTaxElementsTemp
{
    public string TempRowId { get; set; }
    public decimal TrxNo { get; set; }
    public string TaxElements { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FtTaxElementsTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FT_TAX_ELEMENTS_TEMP");

            entity.Property(e => e.TaxElements)
                .HasColumnName("TAX_ELEMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TempRowId)
                .HasColumnName("TEMP_ROW_ID")
                .HasColumnType("ROWID");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
