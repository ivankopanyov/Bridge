namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArAgingOptions
{
    public string Code { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArAgingOptions>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_AGING_OPTIONS");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(23)
                .IsUnicode(false);
        });
	}
}
