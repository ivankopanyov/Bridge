namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoundingFactorsView
{
    public string Code { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoundingFactorsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROUNDING_FACTORS_VIEW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
