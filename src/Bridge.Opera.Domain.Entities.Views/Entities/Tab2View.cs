namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Tab2View
{
    public string? Col { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tab2View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAB2_VIEW");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .IsUnicode(false);
        });
	}
}
