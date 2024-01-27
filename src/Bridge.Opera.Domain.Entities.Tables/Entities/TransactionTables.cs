namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TransactionTables
{
    public string TableName { get; set; }
    public string TableOwner { get; set; }
    public string DownloadType { get; set; }
    public string UploadYn { get; set; }
    public string ModuleName { get; set; }
    public decimal? UploadSeq { get; set; }
    public string PkColumn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string ColumnList { get; set; }
    public string WhereClause { get; set; }
    public string UpdateWhereclause { get; set; }
    public string UpdateSetstring1 { get; set; }
    public string UpdateSetstring2 { get; set; }
    public string InsertCollist { get; set; }
    public string InsertColvalues1 { get; set; }
    public string InsertColvalues2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TransactionTables>(entity =>
        {
            entity.HasKey(e => new { e.TableName, e.DownloadType })
                .HasName("TRT_PK");

            entity.ToTable("TRANSACTION$TABLES");

            entity.HasIndex(e => e.DownloadType)
                .HasName("TRT_DLTYPE_IDX");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DownloadType)
                .HasColumnName("DOWNLOAD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'DYNAMIC'");

            entity.Property(e => e.ColumnList)
                .HasColumnName("COLUMN_LIST")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertCollist)
                .HasColumnName("INSERT_COLLIST")
                .IsUnicode(false);

            entity.Property(e => e.InsertColvalues1)
                .HasColumnName("INSERT_COLVALUES1")
                .IsUnicode(false);

            entity.Property(e => e.InsertColvalues2)
                .HasColumnName("INSERT_COLVALUES2")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleName)
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PkColumn)
                .HasColumnName("PK_COLUMN")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TableOwner)
                .HasColumnName("TABLE_OWNER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateSetstring1)
                .HasColumnName("UPDATE_SETSTRING1")
                .IsUnicode(false);

            entity.Property(e => e.UpdateSetstring2)
                .HasColumnName("UPDATE_SETSTRING2")
                .IsUnicode(false);

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateWhereclause)
                .HasColumnName("UPDATE_WHERECLAUSE")
                .IsUnicode(false);

            entity.Property(e => e.UploadSeq)
                .HasColumnName("UPLOAD_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UploadYn)
                .HasColumnName("UPLOAD_YN")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.WhereClause)
                .HasColumnName("WHERE_CLAUSE")
                .IsUnicode(false);
        });
	}
}
