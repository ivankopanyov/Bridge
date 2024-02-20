namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BofPopulateData
{
    public decimal? SessId { get; set; }
    public decimal? RecordId { get; set; }
    public string? OutputValue { get; set; }
    public string? TrxCode { get; set; }
    public decimal? OrderBy { get; set; }
    public string? RecordSubtype { get; set; }
    public string? ChildRecordSubtype { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofPopulateData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BOF_POPULATE_DATA");

            entity.Property(e => e.ChildRecordSubtype)
                .HasColumnName("CHILD_RECORD_SUBTYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutputValue)
                .HasColumnName("OUTPUT_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.RecordId)
                .HasColumnName("RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordSubtype)
                .HasColumnName("RECORD_SUBTYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SessId)
                .HasColumnName("SESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
