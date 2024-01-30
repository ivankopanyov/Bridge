namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinTranAction1
{
    public string? Terminal { get; set; }
    public string? Machine { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? FinActionId { get; set; }
    public string? FinActionDesc { get; set; }
    public string? FinActionEvent { get; set; }
    public string? ReasonCode { get; set; }
    public string? AdjustReason { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Resort { get; set; }
    public string? StatsProcessedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranAction1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_TRAN_ACTION");

            entity.Property(e => e.AdjustReason)
                .HasColumnName("ADJUST_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FinActionDesc)
                .HasColumnName("FIN_ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FinActionEvent)
                .IsRequired()
                .HasColumnName("FIN_ACTION_EVENT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FinActionId)
                .HasColumnName("FIN_ACTION_ID")
                .HasColumnType("NUMBER");

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
