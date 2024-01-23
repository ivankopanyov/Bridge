namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InstallationStatus
{
    public string ObjectName { get; set; }
    public string ObjectType { get; set; }
    public string DiscrepancyLevel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InstallationStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INSTALLATION_STATUS");

            entity.Property(e => e.DiscrepancyLevel)
                .HasColumnName("DISCREPANCY_LEVEL")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.ObjectType)
                .HasColumnName("OBJECT_TYPE")
                .HasMaxLength(19)
                .IsUnicode(false);
        });
	}
}
