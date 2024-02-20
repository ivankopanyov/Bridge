namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiEnabledResort
{
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiEnabledResort>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ENABLED_RESORT");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
