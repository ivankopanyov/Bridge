namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FinTranAction
{
    public string Terminal { get; set; }
    public string Machine { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal FinActionId { get; set; }
    public string FinActionDesc { get; set; }
    public string FinActionType { get; set; }
    public string FinActionEvent { get; set; }
    public string ReasonCode { get; set; }
    public string AdjustReason { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string Resort { get; set; }
    public string StatsProcessedYn { get; set; }
    public string ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranAction>(entity =>
        {
            entity.HasKey(e => e.FinActionId)
                .HasName("ACTION$_PK");

            entity.ToTable("FIN$_TRAN_ACTION");

            entity.HasIndex(e => new { e.BusinessDate, e.ChainCode })
                .HasName("FTA_BUSINESS_DATE_IDX");

            entity.HasIndex(e => new { e.InsertDate, e.ChainCode })
                .HasName("POST_INSERT_DATE_IDX");

            entity.HasIndex(e => new { e.FinActionType, e.BusinessDate, e.ChainCode })
                .HasName("FIN_ACTION_BUSINESS_DATE");

            entity.Property(e => e.FinActionId)
                .HasColumnName("FIN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustReason)
                .HasColumnName("ADJUST_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FinActionDesc)
                .HasColumnName("FIN_ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FinActionEvent)
                .IsRequired()
                .HasColumnName("FIN_ACTION_EVENT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FinActionType)
                .HasColumnName("FIN_ACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'FO'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatsProcessedYn)
                .HasColumnName("STATS_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
