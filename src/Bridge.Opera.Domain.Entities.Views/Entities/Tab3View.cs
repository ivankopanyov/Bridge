namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Tab3View
{
    public string Col { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tab3View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAB3_VIEW");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .IsUnicode(false);
        });
	}
}
