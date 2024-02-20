namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveExpMappingView
{
    public string? MappingType { get; set; }
    public string? ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveExpMappingView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_EXP_MAPPING_VIEW");

            entity.Property(e => e.MappingType)
                .IsRequired()
                .HasColumnName("MAPPING_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
