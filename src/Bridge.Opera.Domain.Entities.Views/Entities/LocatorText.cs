namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LocatorText
{
    public decimal LocatorCode { get; set; }
    public string LocatorText1 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LocatorText>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LOCATOR_TEXT");

            entity.Property(e => e.LocatorCode)
                .HasColumnName("LOCATOR_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocatorText1)
                .HasColumnName("LOCATOR_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
