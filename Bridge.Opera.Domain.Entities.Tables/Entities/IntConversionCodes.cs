namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntConversionCodes
{
    public string ConversionCode { get; set; }
    public string Description { get; set; }
    public string LabelConversionCode { get; set; }
    public string InterfaceId { get; set; }
    public string LovQuery { get; set; }
    public string MasterCode { get; set; }
    public string Xmltypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntConversionCodes>(entity =>
        {
            entity.HasKey(e => new { e.ConversionCode, e.InterfaceId })
                .HasName("INT_CC_PK");

            entity.ToTable("INT_CONVERSION_CODES");

            entity.Property(e => e.ConversionCode)
                .HasColumnName("CONVERSION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'SID-INTERFACE'");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LabelConversionCode)
                .HasColumnName("LABEL_CONVERSION_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.LovQuery)
                .HasColumnName("LOV_QUERY")
                .IsUnicode(false);

            entity.Property(e => e.MasterCode)
                .HasColumnName("MASTER_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Xmltypes)
                .HasColumnName("XMLTYPES")
                .IsUnicode(false);
        });
	}
}
