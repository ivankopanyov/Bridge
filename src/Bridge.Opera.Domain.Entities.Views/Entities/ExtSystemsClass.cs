namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExtSystemsClass
{
    public string InterfaceId { get; set; }
    public string SystemType { get; set; }
    public string SystemClass { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtSystemsClass>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXT_SYSTEMS_CLASS");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SystemClass)
                .HasColumnName("SYSTEM_CLASS")
                .HasMaxLength(82)
                .IsUnicode(false);

            entity.Property(e => e.SystemType)
                .HasColumnName("SYSTEM_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
