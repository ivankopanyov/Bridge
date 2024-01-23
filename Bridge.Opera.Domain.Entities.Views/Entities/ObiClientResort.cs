namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiClientResort
{
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiClientResort>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CLIENT_RESORT");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
