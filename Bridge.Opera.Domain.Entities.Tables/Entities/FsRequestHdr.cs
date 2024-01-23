namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsRequestHdr
{
    public decimal ReqId { get; set; }
    public DateTime ReqDatetime { get; set; }
    public string ReqSystem { get; set; }
    public decimal? ParRowCnt { get; set; }
    public decimal? RespRowCnt { get; set; }
    public decimal? RespTimeSec { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ReqError { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsRequestHdr>(entity =>
        {
            entity.HasKey(e => e.ReqId)
                .HasName("FS_REQUEST_HDR_PK");

            entity.ToTable("FS_REQUEST_HDR");

            entity.HasIndex(e => e.ReqDatetime)
                .HasName("FS_REQUEST_HDR_IND");

            entity.Property(e => e.ReqId)
                .HasColumnName("REQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ParRowCnt)
                .HasColumnName("PAR_ROW_CNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReqDatetime)
                .HasColumnName("REQ_DATETIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ReqError)
                .HasColumnName("REQ_ERROR")
                .IsUnicode(false);

            entity.Property(e => e.ReqSystem)
                .HasColumnName("REQ_SYSTEM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RespRowCnt)
                .HasColumnName("RESP_ROW_CNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RespTimeSec)
                .HasColumnName("RESP_TIME_SEC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
