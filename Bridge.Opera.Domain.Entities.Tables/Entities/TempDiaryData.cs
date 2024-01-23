namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempDiaryData
{
    public string Resort { get; set; }
    public string Room { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempDiaryData>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room })
                .HasName("TEMP_DIARY_DATA_PK");

            entity.ToTable("TEMP_DIARY_DATA");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
