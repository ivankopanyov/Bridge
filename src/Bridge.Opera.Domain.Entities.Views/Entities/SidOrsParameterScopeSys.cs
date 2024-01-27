namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOrsParameterScopeSys
{
    public string ParameterName { get; set; }
    public string ParameterScope { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOrsParameterScopeSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ORS_PARAMETER_SCOPE_SYS");

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterScope)
                .IsRequired()
                .HasColumnName("PARAMETER_SCOPE")
                .HasMaxLength(2)
                .IsUnicode(false);
        });
	}
}
