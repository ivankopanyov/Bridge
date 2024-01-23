namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FolioPurgeRebuildList
{
    public string Resort { get; set; }
    public string TableName { get; set; }
    public decimal? RowsPurged { get; set; }
    public DateTime? PurgeDate { get; set; }
    public string RebuildFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioPurgeRebuildList>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TableName })
                .HasName("FPRL_PK");

            entity.ToTable("FOLIO_PURGE_REBUILD_LIST");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PurgeDate)
                .HasColumnName("PURGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RebuildFlag)
                .HasColumnName("REBUILD_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RowsPurged)
                .HasColumnName("ROWS_PURGED")
                .HasColumnType("NUMBER");
        });
	}
}
