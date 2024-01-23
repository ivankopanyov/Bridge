namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class JavaLog
{
    public decimal? SeqNo { get; set; }
    public string MsgText { get; set; }
    public string CommandLine { get; set; }
    public string DesName { get; set; }
    public string Step { get; set; }
    public decimal? ReportId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? IndexColumn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JavaLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("JAVA_LOG");

            entity.Property(e => e.CommandLine)
                .HasColumnName("COMMAND_LINE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DesName)
                .HasColumnName("DES_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IndexColumn)
                .HasColumnName("INDEX_COLUMN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MsgText)
                .HasColumnName("MSG_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Step)
                .HasColumnName("STEP")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
