namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MeetingmatrixObjects
{
    public string ObjectGroup { get; set; }
    public string ObjectType { get; set; }
    public string ObjectName { get; set; }
    public string ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MeetingmatrixObjects>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.ObjectGroup, e.ObjectType })
                .HasName("MMO_PK");

            entity.ToTable("MEETINGMATRIX_OBJECTS");

            entity.HasIndex(e => new { e.ObjectType, e.ChainCode })
                .HasName("MMO_UIDX")
                .IsUnique();

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjectGroup)
                .HasColumnName("OBJECT_GROUP")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ObjectType)
                .HasColumnName("OBJECT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .IsRequired()
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
