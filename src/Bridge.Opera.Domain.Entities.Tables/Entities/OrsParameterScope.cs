namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrsParameterScope
{
    public string ParameterName { get; set; }
    public string ParameterScope { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrsParameterScope>(entity =>
        {
            entity.HasKey(e => e.ParameterName)
                .HasName("OPE_PK");

            entity.ToTable("ORS_PARAMETER_SCOPE");

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterScope)
                .IsRequired()
                .HasColumnName("PARAMETER_SCOPE")
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'P'");
        });
	}
}
