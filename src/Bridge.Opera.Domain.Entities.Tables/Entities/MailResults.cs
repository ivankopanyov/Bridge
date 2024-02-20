namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailResults
{
    public decimal? HitlistId { get; set; }
    public string? Tagged { get; set; }
    public string? Column1 { get; set; }
    public string? Column2 { get; set; }
    public string? Column3 { get; set; }
    public string? CharRecordId1 { get; set; }
    public decimal? NumberRecordId1 { get; set; }
    public decimal? NumberRecordId2 { get; set; }
    public string? Column1Key { get; set; }
    public string? Column2Key { get; set; }
    public string? Column3Key { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailResults>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MAIL_RESULTS");

            entity.HasIndex(e => new { e.HitlistId, e.CharRecordId1, e.NumberRecordId1, e.Tagged })
                .HasName("MAILR_CHAR_IDX");

            entity.HasIndex(e => new { e.HitlistId, e.NumberRecordId1, e.NumberRecordId2, e.Tagged })
                .HasName("MAILR_NUMBER_IDX");

            entity.Property(e => e.CharRecordId1)
                .HasColumnName("CHAR_RECORD_ID1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Column1)
                .HasColumnName("COLUMN1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column1Key)
                .HasColumnName("COLUMN1_KEY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column2)
                .HasColumnName("COLUMN2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column2Key)
                .HasColumnName("COLUMN2_KEY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column3)
                .HasColumnName("COLUMN3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Column3Key)
                .HasColumnName("COLUMN3_KEY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HitlistId)
                .HasColumnName("HITLIST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberRecordId1)
                .HasColumnName("NUMBER_RECORD_ID1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberRecordId2)
                .HasColumnName("NUMBER_RECORD_ID2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tagged)
                .HasColumnName("TAGGED")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
