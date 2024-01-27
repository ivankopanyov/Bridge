namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MhResortView
{
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MhResortView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MH_RESORT_VIEW");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(60)
                .IsUnicode(false);
        });
	}
}
