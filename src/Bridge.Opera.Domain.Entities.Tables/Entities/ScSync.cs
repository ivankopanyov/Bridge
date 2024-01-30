namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScSync
{
    public string? Resort { get; set; }
    public decimal? SyncId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? SyncDate { get; set; }
    public decimal? SyncUser { get; set; }
    public string? TableName { get; set; }
    public string? TableRowid { get; set; }
    public string? Action { get; set; }
    public string? LogTxt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScSync>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.SyncId })
                .HasName("SC_SYNC_PK");

            entity.ToTable("SC_SYNC");

            entity.HasIndex(e => e.InsertDate)
                .HasName("SC_SYNC_INSERT_DATE_IDX");

            entity.HasIndex(e => e.SyncDate)
                .HasName("SC_SYNC_SYNC_DATE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SyncId)
                .HasColumnName("SYNC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LogTxt)
                .HasColumnName("LOG_TXT")
                .IsUnicode(false);

            entity.Property(e => e.SyncDate)
                .HasColumnName("SYNC_DATE")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.SyncUser)
                .HasColumnName("SYNC_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TableRowid)
                .HasColumnName("TABLE_ROWID")
                .HasColumnType("ROWID");
        });
	}
}
