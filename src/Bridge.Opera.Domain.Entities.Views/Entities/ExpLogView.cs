namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpLogView
{
    public string? ExpLogId { get; set; }
    public decimal? ExpLogSeq { get; set; }
    public string? LogTxt { get; set; }
    public string? CharInsertTime { get; set; }
    public DateTime? InsertTime { get; set; }
    public string? FileId { get; set; }
    public string? DataId { get; set; }
    public string? Sid { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpLogView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_LOG_VIEW");

            entity.Property(e => e.CharInsertTime)
                .IsRequired()
                .HasColumnName("CHAR_INSERT_TIME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DataId)
                .HasColumnName("DATA_ID")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.ExpLogId)
                .IsRequired()
                .HasColumnName("EXP_LOG_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExpLogSeq)
                .HasColumnName("EXP_LOG_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FileId)
                .HasColumnName("FILE_ID")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.InsertTime)
                .HasColumnName("INSERT_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.LogTxt)
                .HasColumnName("LOG_TXT")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasMaxLength(120)
                .IsUnicode(false);
        });
	}
}
