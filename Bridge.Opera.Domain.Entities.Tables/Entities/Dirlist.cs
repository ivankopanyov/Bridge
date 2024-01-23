namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Dirlist
{
    public string Filename { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Dirlist>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DIRLIST");

            entity.HasIndex(e => e.Filename)
                .HasName("DIRLIST_UK")
                .IsUnique();

            entity.Property(e => e.Filename)
                .HasColumnName("FILENAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
