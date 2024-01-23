namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsSource
{
    public string Src { get; set; }
    public string SrcDesc { get; set; }
    public string SrcTable { get; set; }
    public string SrcCat { get; set; }
    public string WsSoapAction { get; set; }
    public string WsRequestXml { get; set; }
    public string WsResponseXml { get; set; }
    public string AuthWsSoapAction { get; set; }
    public string AuthWsRequestXml { get; set; }
    public string AuthWsResponseXml { get; set; }
    public string InactiveYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsSource>(entity =>
        {
            entity.HasKey(e => e.Src)
                .HasName("FS_SOURCE_PK");

            entity.ToTable("FS_SOURCE");

            entity.Property(e => e.Src)
                .HasColumnName("SRC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AuthWsRequestXml)
                .HasColumnName("AUTH_WS_REQUEST_XML")
                .HasColumnType("CLOB");

            entity.Property(e => e.AuthWsResponseXml)
                .HasColumnName("AUTH_WS_RESPONSE_XML")
                .HasColumnType("CLOB");

            entity.Property(e => e.AuthWsSoapAction)
                .HasColumnName("AUTH_WS_SOAP_ACTION")
                .IsUnicode(false);

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SrcCat)
                .IsRequired()
                .HasColumnName("SRC_CAT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SrcDesc)
                .HasColumnName("SRC_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SrcTable)
                .HasColumnName("SRC_TABLE")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WsRequestXml)
                .HasColumnName("WS_REQUEST_XML")
                .HasColumnType("CLOB");

            entity.Property(e => e.WsResponseXml)
                .HasColumnName("WS_RESPONSE_XML")
                .HasColumnType("CLOB");

            entity.Property(e => e.WsSoapAction)
                .HasColumnName("WS_SOAP_ACTION")
                .IsUnicode(false);
        });
	}
}
