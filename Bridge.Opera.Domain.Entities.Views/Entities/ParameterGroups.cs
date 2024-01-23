namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ParameterGroups
{
    public string ParameterGroup { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ParameterGroups>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PARAMETER_GROUPS");

            entity.Property(e => e.ParameterGroup)
                .HasColumnName("PARAMETER_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
