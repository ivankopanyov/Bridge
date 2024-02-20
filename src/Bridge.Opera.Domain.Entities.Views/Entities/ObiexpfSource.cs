namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpfSource
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? Resort { get; set; }
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? SourceCode { get; set; }
    public string? SourceDesc { get; set; }
    public string? SourceGroup { get; set; }
    public string? SourceGroupDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ResortId { get; set; }
    public string? SourceCodeKey { get; set; }
    public string? SourceGroupKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpfSource>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPF_SOURCE");

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

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(41)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.SourceCode)
                .IsRequired()
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCodeKey)
                .HasColumnName("SOURCE_CODE_KEY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceDesc)
                .HasColumnName("SOURCE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceGroup)
                .HasColumnName("SOURCE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceGroupDesc)
                .HasColumnName("SOURCE_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceGroupKey)
                .HasColumnName("SOURCE_GROUP_KEY")
                .IsUnicode(false);
        });
	}
}
