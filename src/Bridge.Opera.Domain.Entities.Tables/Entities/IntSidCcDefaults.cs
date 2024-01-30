namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntSidCcDefaults
{
    public string? ConversionCode { get; set; }
    public string? InterfaceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntSidCcDefaults>(entity =>
        {
            entity.HasKey(e => new { e.ConversionCode, e.InterfaceId })
                .HasName("INT_SID_CC_DEFAULTS_PK");

            entity.ToTable("INT_SID_CC_DEFAULTS");

            entity.Property(e => e.ConversionCode)
                .HasColumnName("CONVERSION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'SID-INTERFACE'");
        });
	}
}
