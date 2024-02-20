namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomClassExceptions
{
    public string? Resort { get; set; }
    public string? TableName { get; set; }
    public string? RoomCategory { get; set; }
    public string? ToRoomClass { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomClassExceptions>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ROOM_CLASS_EXCEPTIONS");

            entity.HasIndex(e => new { e.Resort, e.TableName })
                .HasName("RMCLASS_EXCEPTION_IDX");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomClass)
                .HasColumnName("TO_ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
