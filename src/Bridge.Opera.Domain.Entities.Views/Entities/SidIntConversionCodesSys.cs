namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidIntConversionCodesSys
{
    public string? ConversionCode { get; set; }
    public string? Description { get; set; }
    public string? LabelConversionCode { get; set; }
    public string? InterfaceId { get; set; }
    public string? LovQuery { get; set; }
    public string? MasterCode { get; set; }
    public string? Xmltypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidIntConversionCodesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INT_CONVERSION_CODES_SYS");

            entity.Property(e => e.ConversionCode)
                .IsRequired()
                .HasColumnName("CONVERSION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
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
