namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GlNumbers
{
    public string GlNum { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GlNumbers>(entity =>
        {
            entity.HasKey(e => e.GlNum)
                .HasName("GL_PK");

            entity.ToTable("GL_NUMBERS");

            entity.Property(e => e.GlNum)
                .HasColumnName("GL_NUM")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
