namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DependentParameterView
{
    public string? ParameterName { get; set; }
    public string? DependentParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DependentParameterView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DEPENDENT_PARAMETER_VIEW");

            entity.Property(e => e.DependentParameterName)
                .IsRequired()
                .HasColumnName("DEPENDENT_PARAMETER_NAME")
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
