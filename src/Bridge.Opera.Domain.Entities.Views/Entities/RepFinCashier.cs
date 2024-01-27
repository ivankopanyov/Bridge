namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepFinCashier
{
    public decimal CashierId { get; set; }
    public string Title { get; set; }
    public DateTime? Timeoffirstopen { get; set; }
    public DateTime? Timeoflastclose { get; set; }
    public DateTime? Dateoflastuse { get; set; }
    public decimal? MaxNoOpen { get; set; }
    public decimal? TimesOpened { get; set; }
    public decimal? CcAmt { get; set; }
    public decimal? CheckAmt { get; set; }
    public decimal? OpayAmt { get; set; }
    public decimal? FcurrAmt { get; set; }
    public decimal? CashAmt { get; set; }
    public decimal? AllTranAmt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepFinCashier>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_FIN_CASHIER");

            entity.Property(e => e.AllTranAmt)
                .HasColumnName("ALL_TRAN_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashAmt)
                .HasColumnName("CASH_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcAmt)
                .HasColumnName("CC_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckAmt)
                .HasColumnName("CHECK_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dateoflastuse)
                .HasColumnName("DATEOFLASTUSE")
                .HasColumnType("DATE");

            entity.Property(e => e.FcurrAmt)
                .HasColumnName("FCURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxNoOpen)
                .HasColumnName("MAX_NO_OPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpayAmt)
                .HasColumnName("OPAY_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Timeoffirstopen)
                .HasColumnName("TIMEOFFIRSTOPEN")
                .HasColumnType("DATE");

            entity.Property(e => e.Timeoflastclose)
                .HasColumnName("TIMEOFLASTCLOSE")
                .HasColumnType("DATE");

            entity.Property(e => e.TimesOpened)
                .HasColumnName("TIMES_OPENED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
