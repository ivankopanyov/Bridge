namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Tab1View
{
    public string? Col { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tab1View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAB1_VIEW");

            entity.Property(e => e.Col)
                .HasColumnName("COL")
                .IsUnicode(false);
        });
	}
}
