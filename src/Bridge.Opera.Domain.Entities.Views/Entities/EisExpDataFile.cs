namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisExpDataFile
{
    public decimal? ExpDataId { get; set; }
    public decimal? ExpFileSeq { get; set; }
    public string? ExpFileLoc { get; set; }
    public string? FileName { get; set; }
    public decimal? RecordStart { get; set; }
    public decimal? RecordEnd { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? FileExtn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisExpDataFile>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_EXP_DATA_FILE");

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpFileLoc)
                .HasColumnName("EXP_FILE_LOC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ExpFileSeq)
                .HasColumnName("EXP_FILE_SEQ")
                .HasColumnType("NUMBER");

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
        });
	}
}
