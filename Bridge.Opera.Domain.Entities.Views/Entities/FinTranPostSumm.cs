namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinTranPostSumm
{
    public decimal? ResvNameId { get; set; }
    public DateTime? TrxDate { get; set; }
    public string Terminal { get; set; }
    public string Machine { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? FinActionId { get; set; }
    public string FinActionDesc { get; set; }
    public string FinActionEvent { get; set; }
    public string ReasonCode { get; set; }
    public string AdjustReason { get; set; }
    public string TargetResort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string ReasonDesc { get; set; }
    public string AppUser { get; set; }
    public string GuestName { get; set; }
    public string IsCcSurchargeYn { get; set; }
    public string AutoSettleYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranPostSumm>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_TRAN_POST_SUMM");

            entity.Property(e => e.AdjustReason)
                .HasColumnName("ADJUST_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AutoSettleYn)
                .HasColumnName("AUTO_SETTLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FinActionDesc)
                .HasColumnName("FIN_ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FinActionEvent)
                .HasColumnName("FIN_ACTION_EVENT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FinActionId)
                .HasColumnName("FIN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsCcSurchargeYn)
                .HasColumnName("IS_CC_SURCHARGE_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReasonDesc)
                .HasColumnName("REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TargetResort)
                .HasColumnName("TARGET_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
