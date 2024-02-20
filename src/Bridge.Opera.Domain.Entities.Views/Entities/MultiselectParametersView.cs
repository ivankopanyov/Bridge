namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MultiselectParametersView
{
    public string? ParameterName { get; set; }
    public string? WinTtl { get; set; }
    public string? DescLabel { get; set; }
    public string? ValidationFunction { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MultiselectParametersView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MULTISELECT_PARAMETERS_VIEW");

            entity.Property(e => e.DescLabel)
                .HasColumnName("DESC_LABEL")
                .HasMaxLength(600)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(39)
                .IsUnicode(false);

            entity.Property(e => e.ValidationFunction)
                .HasColumnName("VALIDATION_FUNCTION")
                .HasMaxLength(144)
                .IsUnicode(false);

            entity.Property(e => e.WinTtl)
                .HasColumnName("WIN_TTL")
                .HasMaxLength(600)
                .IsUnicode(false);
        });
	}
}
