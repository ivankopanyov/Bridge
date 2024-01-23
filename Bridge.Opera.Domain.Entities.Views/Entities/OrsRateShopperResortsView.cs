namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrsRateShopperResortsView
{
    public string Resort { get; set; }
    public string Name { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrsRateShopperResortsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORS_RATE_SHOPPER_RESORTS_VIEW");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
