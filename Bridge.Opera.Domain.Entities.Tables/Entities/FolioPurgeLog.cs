namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FolioPurgeLog
{
    public string Resort { get; set; }
    public string TableName { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal NameId { get; set; }
    public string ErrorMsg { get; set; }
    public DateTime? PurgeDate { get; set; }
    public string LogAction { get; set; }
    public decimal? RowsPurged { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioPurgeLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FOLIO_PURGE_LOG");

            entity.HasIndex(e => new { e.Resort, e.LogAction, e.ResvNameId, e.NameId })
                .HasName("FOLIO_PURGE_LOG_IND1");

            entity.Property(e => e.ErrorMsg)
                .HasColumnName("ERROR_MSG")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.LogAction)
                .IsRequired()
                .HasColumnName("LOG_ACTION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'LOG'");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PurgeDate)
                .HasColumnName("PURGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowsPurged)
                .HasColumnName("ROWS_PURGED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
