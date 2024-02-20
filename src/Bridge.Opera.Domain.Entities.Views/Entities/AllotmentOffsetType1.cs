namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AllotmentOffsetType1
{
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? OffsetType { get; set; }
    public string? IgnoreOffsetYn { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentOffsetType1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ALLOTMENT_OFFSET_TYPE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IgnoreOffsetYn)
                .HasColumnName("IGNORE_OFFSET_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OffsetType)
                .IsRequired()
                .HasColumnName("OFFSET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
