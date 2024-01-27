namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsRequestQuery
{
    public decimal ReqId { get; set; }
    public string Src { get; set; }
    public string Query { get; set; }
    public string QueryFull { get; set; }
    public decimal? TimeMsec { get; set; }
    public string QueryError { get; set; }
    public string RequestXml { get; set; }
    public string ResponseXml { get; set; }
    public string AuthRequestXml { get; set; }
    public string AuthResponseXml { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsRequestQuery>(entity =>
        {
            entity.HasKey(e => new { e.ReqId, e.Src })
                .HasName("FS_REQUEST_QUERY_PK");

            entity.ToTable("FS_REQUEST_QUERY");

            entity.Property(e => e.ReqId)
                .HasColumnName("REQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Src)
                .HasColumnName("SRC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AuthRequestXml)
                .HasColumnName("AUTH_REQUEST_XML")
                .HasColumnType("CLOB");

            entity.Property(e => e.AuthResponseXml)
                .HasColumnName("AUTH_RESPONSE_XML")
                .HasColumnType("CLOB");

            entity.Property(e => e.Query)
                .IsRequired()
                .HasColumnName("QUERY")
                .IsUnicode(false);

            entity.Property(e => e.QueryError)
                .HasColumnName("QUERY_ERROR")
                .IsUnicode(false);

            entity.Property(e => e.QueryFull)
                .HasColumnName("QUERY_FULL")
                .HasColumnType("CLOB");

            entity.Property(e => e.RequestXml)
                .HasColumnName("REQUEST_XML")
                .HasColumnType("CLOB");

            entity.Property(e => e.ResponseXml)
                .HasColumnName("RESPONSE_XML")
                .HasColumnType("CLOB");

            entity.Property(e => e.TimeMsec)
                .HasColumnName("TIME_MSEC")
                .HasColumnType("NUMBER");
        });
	}
}
