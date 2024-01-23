namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcCurrencyView
{
    public string Resort { get; set; }
    public string DbfLogo { get; set; }
    public int? RowNum { get; set; }
    public string OperaCode { get; set; }
    public string VendorCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcCurrencyView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_CURRENCY_VIEW");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(6)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OperaCode)
                .HasColumnName("OPERA_CODE")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowNum)
                .HasColumnName("ROW_NUM")
                .HasColumnType("NUMBER(6)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VendorCode)
                .HasColumnName("VENDOR_CODE")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
