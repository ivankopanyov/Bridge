namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Tab7View
{
    public string Col { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tab7View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAB7_VIEW");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .IsUnicode(false);
        });
	}
}
