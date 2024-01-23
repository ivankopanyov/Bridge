namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RwServerLog
{
    public decimal? SeqNo { get; set; }
    public decimal? JobId { get; set; }
    public string CharInsDate { get; set; }
    public string MsgText { get; set; }
    public string CommandLine { get; set; }
    public string DesName { get; set; }
    public DateTime? InsertDate { get; set; }
    public string Step { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RwServerLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RW_SERVER_LOG");

            entity.HasIndex(e => e.InsertDate)
                .HasName("RW_SERVER_LOG_IND1");

            entity.Property(e => e.CharInsDate)
                .HasColumnName("CHAR_INS_DATE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CommandLine)
                .HasColumnName("COMMAND_LINE")
                .IsUnicode(false);

            entity.Property(e => e.DesName)
                .HasColumnName("DES_NAME")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.JobId)
                .HasColumnName("JOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MsgText)
                .HasColumnName("MSG_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Step)
                .HasColumnName("STEP")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
