namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveParameterGroupView
{
    public string? GroupName { get; set; }
    public string? ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveParameterGroupView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_PARAMETER_GROUP_VIEW");

            entity.Property(e => e.GroupName)
                .IsRequired()
                .HasColumnName("GROUP_NAME")
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
