namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CreateJavaLobTable
{
    public string? Name { get; set; }
    public byte[] Lob { get; set; }
    public DateTime? Loadtime { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CreateJavaLobTable>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CREATE$JAVA$LOB$TABLE");

            entity.HasIndex(e => e.Name)
                .HasName("SYS_C0074663")
                .IsUnique();

            entity.Property(e => e.Loadtime)
                .HasColumnName("LOADTIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Lob)
                .HasColumnName("LOB")
                .HasColumnType("BLOB");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
