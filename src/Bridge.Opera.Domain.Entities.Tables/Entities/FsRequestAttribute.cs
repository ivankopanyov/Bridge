namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsRequestAttribute
{
    public decimal? ReqId { get; set; }
    public string? Src { get; set; }
    public decimal? RowNo { get; set; }
    public string? Atr { get; set; }
    public string? AtrValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsRequestAttribute>(entity =>
        {
            entity.HasKey(e => new { e.ReqId, e.Src, e.RowNo, e.Atr })
                .HasName("FS_REQUEST_ATTRIBUTE_PK");

            entity.ToTable("FS_REQUEST_ATTRIBUTE");

            entity.Property(e => e.ReqId)
                .HasColumnName("REQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Src)
                .HasColumnName("SRC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RowNo)
                .HasColumnName("ROW_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Atr)
                .HasColumnName("ATR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AtrValue)
                .HasColumnName("ATR_VALUE")
                .IsUnicode(false);
        });
	}
}
