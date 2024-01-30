namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JavaClassMd5Table
{
    public string? Name { get; set; }
    public Guid? Md5 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JavaClassMd5Table>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("JAVA$CLASS$MD5$TABLE");

            entity.HasIndex(e => e.Name)
                .HasName("SYS_C0030122")
                .IsUnique();

            entity.Property(e => e.Md5).HasColumnName("MD5");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
