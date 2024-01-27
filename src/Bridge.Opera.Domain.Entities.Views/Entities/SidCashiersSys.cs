namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidCashiersSys
{
    public decimal? CashierId { get; set; }
    public string Title { get; set; }
    public string State { get; set; }
    public decimal? AmtFloat { get; set; }
    public string IncludeFloat { get; set; }
    public string GenCashierYn { get; set; }
    public string Timeoflastclose { get; set; }
    public string CashierBal { get; set; }
    public string Dateoflastuse { get; set; }
    public string LastOpened { get; set; }
    public string MaxNoOpen { get; set; }
    public string Timeoffirstopen { get; set; }
    public string TimesOpened { get; set; }
    public string AmtDiffInitial { get; set; }
    public string InsertUser { get; set; }
    public string InsertDate { get; set; }
    public string UpdateDate { get; set; }
    public string UpdateUser { get; set; }
    public string ActiveYn { get; set; }
    public string Resort { get; set; }
    public string TranActionId { get; set; }
    public string CsrTrxNo { get; set; }
    public string ClosureInProgressYn { get; set; }
    public string ClosureNo { get; set; }
    public string InterfaceCashierYn { get; set; }
    public string InternalUpdateYn { get; set; }
    public string KioskCashierYn { get; set; }
    public string ReservedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidCashiersSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CASHIERS$_SYS");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.AmtDiffInitial)
                .HasColumnName("AMT_DIFF_INITIAL")
                .IsUnicode(false);

            entity.Property(e => e.AmtFloat)
                .HasColumnName("AMT_FLOAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierBal)
                .HasColumnName("CASHIER_BAL")
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClosureInProgressYn)
                .HasColumnName("CLOSURE_IN_PROGRESS_YN")
                .IsUnicode(false);

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .IsUnicode(false);

            entity.Property(e => e.CsrTrxNo)
                .HasColumnName("CSR_TRX_NO")
                .IsUnicode(false);

            entity.Property(e => e.Dateoflastuse)
                .HasColumnName("DATEOFLASTUSE")
                .IsUnicode(false);

            entity.Property(e => e.GenCashierYn)
                .HasColumnName("GEN_CASHIER_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.IncludeFloat)
                .HasColumnName("INCLUDE_FLOAT")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

            entity.Property(e => e.InterfaceCashierYn)
                .HasColumnName("INTERFACE_CASHIER_YN")
                .IsUnicode(false);

            entity.Property(e => e.InternalUpdateYn)
                .HasColumnName("INTERNAL_UPDATE_YN")
                .IsUnicode(false);

            entity.Property(e => e.KioskCashierYn)
                .HasColumnName("KIOSK_CASHIER_YN")
                .IsUnicode(false);

            entity.Property(e => e.LastOpened)
                .HasColumnName("LAST_OPENED")
                .IsUnicode(false);

            entity.Property(e => e.MaxNoOpen)
                .HasColumnName("MAX_NO_OPEN")
                .IsUnicode(false);

            entity.Property(e => e.ReservedYn)
                .HasColumnName("RESERVED_YN")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasColumnType("CHAR(2000)");

            entity.Property(e => e.Timeoffirstopen)
                .HasColumnName("TIMEOFFIRSTOPEN")
                .IsUnicode(false);

            entity.Property(e => e.Timeoflastclose)
                .HasColumnName("TIMEOFLASTCLOSE")
                .IsUnicode(false);

            entity.Property(e => e.TimesOpened)
                .HasColumnName("TIMES_OPENED")
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasColumnType("CHAR(15)");

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .IsUnicode(false);

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .IsUnicode(false);
        });
	}
}
