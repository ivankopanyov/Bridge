namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveParameterView
{
    public string ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveParameterView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_PARAMETER_VIEW");

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
