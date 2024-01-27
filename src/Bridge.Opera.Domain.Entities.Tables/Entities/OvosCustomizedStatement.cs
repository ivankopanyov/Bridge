namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosCustomizedStatement
{
    public decimal StmntId { get; set; }
    public string Resort { get; set; }
    public decimal AccountCode { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public string FileName { get; set; }
    public string Description { get; set; }
    public byte[] BfileLocator { get; set; }
    public byte[] Attachment { get; set; }
    public string AttachmentLocation { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string StatementType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosCustomizedStatement>(entity =>
        {
            entity.HasKey(e => e.StmntId)
                .HasName("OVOS_CUST_STAT_PK");

            entity.ToTable("OVOS_CUSTOMIZED_STATEMENT");

            entity.HasIndex(e => new { e.Resort, e.AccountCode, e.FromDate, e.ToDate, e.StatementType })
                .HasName("OVOS_CUST_STAT_UK")
                .IsUnique();

            entity.Property(e => e.StmntId)
                .HasColumnName("STMNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attachment)
                .HasColumnName("ATTACHMENT")
                .HasColumnType("BLOB");

            entity.Property(e => e.AttachmentLocation)
                .IsRequired()
                .HasColumnName("ATTACHMENT_LOCATION")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.BfileLocator)
                .HasColumnName("BFILE_LOCATOR")
                .HasColumnType("BFILE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .HasColumnName("FILE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatementType)
                .IsRequired()
                .HasColumnName("STATEMENT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
