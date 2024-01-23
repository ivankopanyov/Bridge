namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Tab5View
{
    public string Col { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tab5View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAB5_VIEW");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .IsUnicode(false);
        });
	}
}
