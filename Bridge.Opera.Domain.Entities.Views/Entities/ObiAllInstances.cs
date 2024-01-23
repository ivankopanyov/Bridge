namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiAllInstances
{
    public string InstId { get; set; }
    public string InstanceName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAllInstances>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ALL_INSTANCES");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InstanceName)
                .HasColumnName("INSTANCE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
