namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveManagerReport
{
    public string? ManagerReport { get; set; }
    public string? ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveManagerReport>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_MANAGER_REPORT");

            entity.Property(e => e.ManagerReport)
                .HasColumnName("MANAGER_REPORT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
