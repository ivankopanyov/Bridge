namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcCfgView
{
    public string? Resort { get; set; }
    public string? DbfLogo { get; set; }
    public int? RowNum { get; set; }
    public string? OriginCode { get; set; }
    public string? MerchantId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcCfgView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_CFG_VIEW");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(6)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MerchantId)
                .HasColumnName("MERCHANT_ID")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OriginCode)
                .HasColumnName("ORIGIN_CODE")
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
        });
	}
}
