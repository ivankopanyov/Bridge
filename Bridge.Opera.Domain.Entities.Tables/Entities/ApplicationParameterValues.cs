namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ApplicationParameterValues
{
    public string Resort { get; set; }
    public string ParameterName { get; set; }
    public string ParameterValue { get; set; }
    public string DisplayYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ApplicationParameterValues>(entity =>
        {
            entity.HasKey(e => new { e.ParameterName, e.Resort })
                .HasName("APP_PARAM_VALUES_PK");

            entity.ToTable("APPLICATION_PARAMETER_VALUES");

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
