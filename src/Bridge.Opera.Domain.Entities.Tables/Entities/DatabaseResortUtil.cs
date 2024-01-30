namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DatabaseResortUtil
{
    public string? DatabaseId { get; set; }
    public string? Resort { get; set; }
    public string? OldDatabaseId { get; set; }
    public string? Status { get; set; }
    public string? ProcessingMsg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DatabaseResortUtil>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DATABASE_RESORT_UTIL");

            entity.HasIndex(e => new { e.DatabaseId, e.Resort })
                .HasName("DB_RESORT_UTL_UK_IDX")
                .IsUnique();

            entity.Property(e => e.DatabaseId)
                .IsRequired()
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OldDatabaseId)
                .IsRequired()
                .HasColumnName("OLD_DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcessingMsg)
                .HasColumnName("PROCESSING_MSG")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
