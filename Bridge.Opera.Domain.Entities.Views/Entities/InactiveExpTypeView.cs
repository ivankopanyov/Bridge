namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveExpTypeView
{
    public string ExportType { get; set; }
    public string ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveExpTypeView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_EXP_TYPE_VIEW");

            entity.Property(e => e.ExportType)
                .IsRequired()
                .HasColumnName("EXPORT_TYPE")
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
