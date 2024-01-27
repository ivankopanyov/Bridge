namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExternalReferenceTypeLov
{
    public string InterfaceId { get; set; }
    public string IntDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExternalReferenceTypeLov>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXTERNAL_REFERENCE_TYPE_LOV");

            entity.Property(e => e.IntDescription)
                .HasColumnName("INT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
