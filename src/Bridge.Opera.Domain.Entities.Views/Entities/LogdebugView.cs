namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LogdebugView
{
    public string MsgText { get; set; }
    public string MessageType { get; set; }
    public DateTime? InsertDate { get; set; }
    public string InsertTime { get; set; }
    public string CharInsDate { get; set; }
    public decimal? Seq { get; set; }
    public string InputSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LogdebugView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LOGDEBUG_VIEW");

            entity.Property(e => e.CharInsDate)
                .HasColumnName("CHAR_INS_DATE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InputSeq)
                .HasColumnName("INPUT_SEQ")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertTime)
                .HasColumnName("INSERT_TIME")
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .HasColumnName("MESSAGE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.MsgText)
                .HasColumnName("MSG_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER");
        });
	}
}
