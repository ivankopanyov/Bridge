namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Tab8View
{
    public string Col { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tab8View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAB8_VIEW");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .IsUnicode(false);
        });
	}
}
