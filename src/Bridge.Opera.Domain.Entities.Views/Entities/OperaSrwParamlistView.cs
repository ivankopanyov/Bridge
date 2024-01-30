namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaSrwParamlistView
{
    public string? Name { get; set; }
    public string? Value { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaSrwParamlistView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_SRW_PARAMLIST_VIEW");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .IsUnicode(false);

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .IsUnicode(false);
        });
	}
}
