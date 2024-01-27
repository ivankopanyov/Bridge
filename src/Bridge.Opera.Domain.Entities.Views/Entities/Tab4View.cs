namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Tab4View
{
    public string Col { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tab4View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAB4_VIEW");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .IsUnicode(false);
        });
	}
}
