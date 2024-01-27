namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpDataFile
{
    public decimal ExpDataId { get; set; }
    public decimal ExpFileSeq { get; set; }
    public string ExpFileLoc { get; set; }
    public string FileName { get; set; }
    public decimal? RecordStart { get; set; }
    public decimal? RecordEnd { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string FileExtn { get; set; }
    public string ErrorText { get; set; }

    public virtual ExpDataHdr ExpData { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpDataFile>(entity =>
        {
            entity.HasKey(e => new { e.ExpDataId, e.ExpFileSeq })
                .HasName("EDF_PK");

            entity.ToTable("EXP_DATA_FILE");

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpFileSeq)
                .HasColumnName("EXP_FILE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ErrorText)
                .HasColumnName("ERROR_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.ExpFileLoc)
                .HasColumnName("EXP_FILE_LOC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FileExtn)
                .HasColumnName("FILE_EXTN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .HasColumnName("FILE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RecordEnd)
                .HasColumnName("RECORD_END")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordStart)
                .HasColumnName("RECORD_START")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ExpDataHdr)))
				entity.Ignore(e => e.ExpData);
			else
	            entity.HasOne(d => d.ExpData)
	                .WithMany(p => p.ExpDataFile)
	                .HasForeignKey(d => d.ExpDataId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EDF_EDH_FK");
        });
	}
}
