namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScreenParameters
{
    public string? FormName { get; set; }
    public string? ParameterName { get; set; }
    public string? ParameterValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScreenParameters>(entity =>
        {
            entity.HasKey(e => new { e.FormName, e.ParameterName })
                .HasName("SCREEN_PARAMETERS_PK");

            entity.ToTable("SCREEN_PARAMETERS");

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValue)
                .IsRequired()
                .HasColumnName("PARAMETER_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
