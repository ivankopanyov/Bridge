namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SessionMemoryLog
{
    public decimal? SmlSeqno { get; set; }
    public decimal? Sid { get; set; }
    public decimal? Audsid { get; set; }
    public string? FormName { get; set; }
    public decimal? UgaMemory { get; set; }
    public decimal? PgaMemory { get; set; }
    public string? Terminal { get; set; }
    public string? Resort { get; set; }
    public string? ModuleInfo { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? AppMemory { get; set; }
    public decimal? AppPrivMemory { get; set; }
    public decimal? AppPrivMemoryPeak { get; set; }
    public decimal? BufferGets { get; set; }
    public decimal? DiffBufferGets { get; set; }
    public string? TransactionInfoText { get; set; }
    public string? ProcessInfo { get; set; }
    public string? CharInsertDate { get; set; }
    public decimal? InstanceId { get; set; }
    public decimal? PgaMemoryDiff { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SessionMemoryLog>(entity =>
        {
            entity.HasKey(e => e.SmlSeqno)
                .HasName("SML_PK");

            entity.ToTable("SESSION_MEMORY_LOG");

            entity.Property(e => e.SmlSeqno)
                .HasColumnName("SML_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppMemory)
                .HasColumnName("APP_MEMORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppPrivMemory)
                .HasColumnName("APP_PRIV_MEMORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppPrivMemoryPeak)
                .HasColumnName("APP_PRIV_MEMORY_PEAK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Audsid)
                .HasColumnName("AUDSID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BufferGets)
                .HasColumnName("BUFFER_GETS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CharInsertDate)
                .HasColumnName("CHAR_INSERT_DATE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DiffBufferGets)
                .HasColumnName("DIFF_BUFFER_GETS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstanceId)
                .HasColumnName("INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleInfo)
                .HasColumnName("MODULE_INFO")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.PgaMemory)
                .HasColumnName("PGA_MEMORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PgaMemoryDiff)
                .HasColumnName("PGA_MEMORY_DIFF")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessInfo)
                .HasColumnName("PROCESS_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TransactionInfoText)
                .HasColumnName("TRANSACTION_INFO_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.UgaMemory)
                .HasColumnName("UGA_MEMORY")
                .HasColumnType("NUMBER");
        });
	}
}
