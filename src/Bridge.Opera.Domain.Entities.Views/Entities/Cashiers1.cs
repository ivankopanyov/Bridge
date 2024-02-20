namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Cashiers1
{
    public string? ActiveYn { get; set; }
    public string? GenCashierYn { get; set; }
    public DateTime? LastOpened { get; set; }
    public decimal? CashierId { get; set; }
    public string? Title { get; set; }
    public string? State { get; set; }
    public DateTime? Timeoffirstopen { get; set; }
    public DateTime? Timeoflastclose { get; set; }
    public DateTime? Dateoflastuse { get; set; }
    public decimal? MaxNoOpen { get; set; }
    public decimal? TimesOpened { get; set; }
    public decimal? AmtFloat { get; set; }
    public decimal? AmtDiffInitial { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? CashierBal { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? IncludeFloat { get; set; }
    public string? Resort { get; set; }
    public string? InterfaceCashierYn { get; set; }
    public string? KioskCashierYn { get; set; }
    public string? ReservedYn { get; set; }
    public string? ReservedResort { get; set; }
    public decimal? ClosureNo { get; set; }
    public string? ChainCode { get; set; }
    public string? InternalUpdateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Cashiers1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CASHIERS");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AmtDiffInitial)
                .HasColumnName("AMT_DIFF_INITIAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmtFloat)
                .HasColumnName("AMT_FLOAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierBal)
                .HasColumnName("CASHIER_BAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dateoflastuse)
                .HasColumnName("DATEOFLASTUSE")
                .HasColumnType("DATE");

            entity.Property(e => e.GenCashierYn)
                .HasColumnName("GEN_CASHIER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IncludeFloat)
                .IsRequired()
                .HasColumnName("INCLUDE_FLOAT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceCashierYn)
                .HasColumnName("INTERFACE_CASHIER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InternalUpdateYn)
                .HasColumnName("INTERNAL_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.KioskCashierYn)
                .HasColumnName("KIOSK_CASHIER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LastOpened)
                .HasColumnName("LAST_OPENED")
                .HasColumnType("DATE");

            entity.Property(e => e.MaxNoOpen)
                .HasColumnName("MAX_NO_OPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservedResort)
                .HasColumnName("RESERVED_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservedYn)
                .HasColumnName("RESERVED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
