namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiActivityClassDim
{
    public string ActivityClass { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiActivityClassDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ACTIVITY_CLASS_DIM");

            entity.Property(e => e.ActivityClass)
                .HasColumnName("ACTIVITY_CLASS")
                .HasMaxLength(14)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
