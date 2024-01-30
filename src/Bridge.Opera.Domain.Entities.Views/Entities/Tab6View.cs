namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Tab6View
{
    public string? Col { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tab6View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAB6_VIEW");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .IsUnicode(false);
        });
	}
}
