namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiObjectOwners
{
    public string Obj { get; set; }
    public string Owner { get; set; }
    public string ObjectName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiObjectOwners>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_OBJECT_OWNERS");

            entity.Property(e => e.Obj)
                .HasColumnName("OBJ")
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
