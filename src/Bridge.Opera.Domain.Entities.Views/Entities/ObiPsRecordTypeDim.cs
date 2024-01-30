namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPsRecordTypeDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? RecordType { get; set; }
    public string? RecordTypeDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ResortId { get; set; }
    public string? RecordTypeKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPsRecordTypeDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PS_RECORD_TYPE_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RecordTypeDesc)
                .HasColumnName("RECORD_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RecordTypeKey)
                .HasColumnName("RECORD_TYPE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);
        });
	}
}
