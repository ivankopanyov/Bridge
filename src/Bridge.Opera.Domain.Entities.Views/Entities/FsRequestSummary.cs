namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FsRequestSummary
{
    public decimal? HdrReqId { get; set; }
    public string? Atr { get; set; }
    public string? AtrValue { get; set; }
    public decimal? ReqId { get; set; }
    public string? AtrDesc { get; set; }
    public string? Datatype { get; set; }
    public string? AtrCat { get; set; }
    public string? AtrCatDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Src { get; set; }
    public string? SrcDesc { get; set; }
    public decimal? RowNo { get; set; }
    public decimal? SummaryOrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsRequestSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FS_REQUEST_SUMMARY");

            entity.Property(e => e.Atr)
                .HasColumnName("ATR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AtrCat)
                .HasColumnName("ATR_CAT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AtrCatDesc)
                .HasColumnName("ATR_CAT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AtrDesc)
                .HasColumnName("ATR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AtrValue)
                .HasColumnName("ATR_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.Datatype)
                .HasColumnName("DATATYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HdrReqId)
                .HasColumnName("HDR_REQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReqId)
                .HasColumnName("REQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowNo)
                .HasColumnName("ROW_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Src)
                .HasColumnName("SRC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SrcDesc)
                .HasColumnName("SRC_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SummaryOrderBy)
                .HasColumnName("SUMMARY_ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
