namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiSizingHdr
{
    public decimal? SizingId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Status { get; set; }
    public string? Comments { get; set; }
    public string? ErrorDesc { get; set; }
    public string? ErrorCode { get; set; }
    public string? EnvType { get; set; }
    public decimal? EstDatamartSize { get; set; }
    public decimal? EstTablespaceSize { get; set; }
    public decimal? EstTempsegSize { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiSizingHdr>(entity =>
        {
            entity.HasKey(e => e.SizingId)
                .HasName("OBI_SIZING_HDR_PK");

            entity.ToTable("OBI_SIZING_HDR");

            entity.Property(e => e.SizingId)
                .HasColumnName("SIZING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EnvType)
                .HasColumnName("ENV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorCode)
                .HasColumnName("ERROR_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .IsUnicode(false);

            entity.Property(e => e.EstDatamartSize)
                .HasColumnName("EST_DATAMART_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstTablespaceSize)
                .HasColumnName("EST_TABLESPACE_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstTempsegSize)
                .HasColumnName("EST_TEMPSEG_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
