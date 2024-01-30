namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Tab9View
{
    public string? Col { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tab9View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAB9_VIEW");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .IsUnicode(false);
        });
	}
}
