namespace Bridge.Opera.Domain.Entities.Tables;

public partial class XmlUploadLogs
{
    public string? Resort { get; set; }
    public string? ObjectType { get; set; }
    public string? ObjectCode { get; set; }
    public string? Action { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? ErrorDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<XmlUploadLogs>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("XML_UPLOAD_LOGS");

            entity.HasIndex(e => e.InsertDate)
                .HasName("XML_UPLOAD_LOG_IND4");

            entity.HasIndex(e => e.ObjectCode)
                .HasName("XML_UPLOAD_LOG_IND3");

            entity.HasIndex(e => new { e.ObjectType, e.ObjectCode })
                .HasName("XML_UPLOAD_LOG_IND2");

            entity.HasIndex(e => new { e.Resort, e.ObjectType, e.ObjectCode })
                .HasName("XML_UPLOAD_LOG_IND1");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ObjectCode)
                .HasColumnName("OBJECT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ObjectType)
                .IsRequired()
                .HasColumnName("OBJECT_TYPE")
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
