namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpCubeVw
{
    public string? CubeName { get; set; }
    public string? CubeDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpCubeVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_CUBE_VW");

            entity.Property(e => e.CubeDesc)
                .HasColumnName("CUBE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CubeName)
                .HasColumnName("CUBE_NAME")
                .HasMaxLength(16)
                .IsUnicode(false);
        });
	}
}
