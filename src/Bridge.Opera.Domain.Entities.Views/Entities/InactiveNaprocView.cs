namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveNaprocView
{
    public string NaprocName { get; set; }
    public string ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveNaprocView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_NAPROC_VIEW");

            entity.Property(e => e.NaprocName)
                .HasColumnName("NAPROC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
