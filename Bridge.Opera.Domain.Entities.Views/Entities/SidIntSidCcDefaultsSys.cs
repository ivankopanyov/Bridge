namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidIntSidCcDefaultsSys
{
    public string ConversionCode { get; set; }
    public string InterfaceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidIntSidCcDefaultsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INT_SID_CC_DEFAULTS_SYS");

            entity.Property(e => e.ConversionCode)
                .IsRequired()
                .HasColumnName("CONVERSION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
