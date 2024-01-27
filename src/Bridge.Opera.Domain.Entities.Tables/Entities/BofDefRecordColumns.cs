namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BofDefRecordColumns
{
    public decimal BofRecId { get; set; }
    public decimal? BofColId { get; set; }
    public decimal? MainSeqNo { get; set; }
    public decimal? SeqNo { get; set; }
    public decimal BofIntfCode { get; set; }
    public string Resort { get; set; }
    public string ColumnName { get; set; }
    public decimal? ColumnLength { get; set; }
    public string DataType { get; set; }
    public string Format { get; set; }
    public string AmtColumn { get; set; }
    public DateTime? InsertDate { get; set; }
    public string InsertUser { get; set; }
    public string UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string AlignLeftRight { get; set; }

    public virtual BofInterface BofInterface { get; set; }
    public virtual BofDefRecords BofRec { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofDefRecordColumns>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BOF$DEF_RECORD_COLUMNS");

            entity.HasIndex(e => e.BofRecId)
                .HasName("BOF_DEF_REC_COL_FK_IDX");

            entity.HasIndex(e => new { e.BofIntfCode, e.Resort })
                .HasName("INTERFACE_ID_REC_COL_FK_IDX");

            entity.HasIndex(e => new { e.BofIntfCode, e.BofRecId, e.SeqNo, e.BofColId })
                .HasName("BOF_DEF_RECORD_COLUMNS_IDX");

            entity.Property(e => e.AlignLeftRight)
                .HasColumnName("ALIGN_LEFT_RIGHT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AmtColumn)
                .HasColumnName("AMT_COLUMN")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BofColId)
                .HasColumnName("BOF_COL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BofIntfCode)
                .HasColumnName("BOF_INTF_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofRecId)
                .HasColumnName("BOF_REC_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ColumnLength)
                .HasColumnName("COLUMN_LENGTH")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Format)
                .HasColumnName("FORMAT")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MainSeqNo)
                .HasColumnName("MAIN_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(BofDefRecords)))
				entity.Ignore(e => e.BofRec);
			else
	            entity.HasOne(d => d.BofRec)
	                .WithMany()
	                .HasForeignKey(d => d.BofRecId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BOF_DEF_RECORD_REC_COLUMNS_FK");

			if (!types.Contains(typeof(BofInterface)))
				entity.Ignore(e => e.BofInterface);
			else
	            entity.HasOne(d => d.BofInterface)
	                .WithMany()
	                .HasForeignKey(d => new { d.BofIntfCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("INTERFACE_ID_REC_COLUMNS_FK");
        });
	}
}
