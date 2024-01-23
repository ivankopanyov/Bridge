namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpRevenueTypeConfig
{
    public string RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string RevenueType { get; set; }
    public string Description { get; set; }
    public decimal? Vat { get; set; }
    public string FbClass { get; set; }
    public DateTime? NbtInactive { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpRevenueTypeConfig>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_REVENUE_TYPE_CONFIG");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FbClass)
                .HasColumnName("FB_CLASS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NbtInactive)
                .HasColumnName("NBT_INACTIVE")
                .HasColumnType("DATE");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.Vat)
                .HasColumnName("VAT")
                .HasColumnType("NUMBER");
        });
	}
}
