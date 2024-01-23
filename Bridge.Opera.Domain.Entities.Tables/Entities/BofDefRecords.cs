namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BofDefRecords
{
    public decimal BofRecordId { get; set; }
    public string Resort { get; set; }
    public decimal BofIntfCode { get; set; }
    public string RecordType { get; set; }
    public decimal? MainSequenceNo { get; set; }
    public string FileType { get; set; }
    public string RecordDescription { get; set; }
    public string ExportFileLocation { get; set; }
    public string ExportFileName { get; set; }
    public string AppendToFile { get; set; }
    public string FromClause { get; set; }
    public string GroupBy { get; set; }
    public string WhereCondition { get; set; }
    public string BofCode1 { get; set; }
    public string BofCode2 { get; set; }
    public string BofCode3 { get; set; }
    public string BofCode5 { get; set; }
    public string BofCode4 { get; set; }
    public string PreExpProc { get; set; }
    public string PostExpProc { get; set; }

    public virtual BofInterface BofInterface { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofDefRecords>(entity =>
        {
            entity.HasKey(e => e.BofRecordId)
                .HasName("BOF_REC_ID_PK");

            entity.ToTable("BOF$DEF_RECORDS");

            entity.HasIndex(e => new { e.BofIntfCode, e.Resort })
                .HasName("INTERFACE_ID_RECORDS_FK_IDX");

            entity.Property(e => e.BofRecordId)
                .HasColumnName("BOF_RECORD_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppendToFile)
                .HasColumnName("APPEND_TO_FILE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BofCode1)
                .HasColumnName("BOF_CODE1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode2)
                .HasColumnName("BOF_CODE2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode3)
                .HasColumnName("BOF_CODE3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode4)
                .HasColumnName("BOF_CODE4")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode5)
                .HasColumnName("BOF_CODE5")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofIntfCode)
                .HasColumnName("BOF_INTF_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportFileLocation)
                .HasColumnName("EXPORT_FILE_LOCATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExportFileName)
                .HasColumnName("EXPORT_FILE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FileType)
                .HasColumnName("FILE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FromClause)
                .HasColumnName("FROM_CLAUSE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GroupBy)
                .HasColumnName("GROUP_BY")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MainSequenceNo)
                .HasColumnName("MAIN_SEQUENCE_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostExpProc)
                .HasColumnName("POST_EXP_PROC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreExpProc)
                .HasColumnName("PRE_EXP_PROC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecordDescription)
                .HasColumnName("RECORD_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.WhereCondition)
                .HasColumnName("WHERE_CONDITION")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(BofInterface)))
				entity.Ignore(e => e.BofInterface);
			else
	            entity.HasOne(d => d.BofInterface)
	                .WithMany(p => p.BofDefRecords)
	                .HasForeignKey(d => new { d.BofIntfCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("INTERFACE_ID_RECORDS_FK");
        });
	}
}
