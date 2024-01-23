namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiResortUdfs
{
    public string Resort { get; set; }
    public string UdfCategory { get; set; }
    public string UdfType { get; set; }
    public string UdfTypeDesc { get; set; }
    public string UdfAttribute { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiResortUdfs>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RESORT_UDFS");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfAttribute)
                .HasColumnName("UDF_ATTRIBUTE")
                .IsUnicode(false);

            entity.Property(e => e.UdfCategory)
                .IsRequired()
                .HasColumnName("UDF_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfType)
                .IsRequired()
                .HasColumnName("UDF_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfTypeDesc)
                .HasColumnName("UDF_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
