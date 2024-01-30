namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofExportHeader
{
    public string? Resort { get; set; }
    public string? HotelCode { get; set; }
    public string? Name { get; set; }
    public string? AccountPeriod { get; set; }
    public decimal? UserId { get; set; }
    public string? UserName { get; set; }
    public string? BofInterfaceName { get; set; }
    public DateTime? RevTrnsDate { get; set; }
    public DateTime? CityTrnsDate { get; set; }
    public DateTime? MktTrnsDate { get; set; }
    public DateTime? StaTrnsDate { get; set; }
    public decimal? RevenueSeqNo { get; set; }
    public decimal? CityLedSeqno { get; set; }
    public decimal? MktStaSeqNo { get; set; }
    public decimal? DayStaSeqNo { get; set; }
    public string? BofCode1 { get; set; }
    public string? BofCode2 { get; set; }
    public string? BofCode3 { get; set; }
    public string? BofCode4 { get; set; }
    public string? BofCode5 { get; set; }
    public string? BofCode6 { get; set; }
    public string? BofCode7 { get; set; }
    public string? BofCode8 { get; set; }
    public string? BofCode9 { get; set; }
    public string? BofCode10 { get; set; }
    public string? BofCode11 { get; set; }
    public string? BofCode12 { get; set; }
    public string? BofCode13 { get; set; }
    public string? BofCode14 { get; set; }
    public string? BofCode15 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofExportHeader>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_EXPORT_HEADER");

            entity.Property(e => e.AccountPeriod)
                .HasColumnName("ACCOUNT_PERIOD")
                .IsUnicode(false);

            entity.Property(e => e.BofCode1)
                .HasColumnName("BOF_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode10)
                .HasColumnName("BOF_CODE10")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode11)
                .HasColumnName("BOF_CODE11")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode12)
                .HasColumnName("BOF_CODE12")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode13)
                .HasColumnName("BOF_CODE13")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode14)
                .HasColumnName("BOF_CODE14")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode15)
                .HasColumnName("BOF_CODE15")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode2)
                .HasColumnName("BOF_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode3)
                .HasColumnName("BOF_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode4)
                .HasColumnName("BOF_CODE4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode5)
                .HasColumnName("BOF_CODE5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode6)
                .HasColumnName("BOF_CODE6")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode7)
                .HasColumnName("BOF_CODE7")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode8)
                .HasColumnName("BOF_CODE8")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode9)
                .HasColumnName("BOF_CODE9")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofInterfaceName)
                .HasColumnName("BOF_INTERFACE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CityLedSeqno)
                .HasColumnName("CITY_LED_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CityTrnsDate)
                .HasColumnName("CITY_TRNS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DayStaSeqNo)
                .HasColumnName("DAY_STA_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MktStaSeqNo)
                .HasColumnName("MKT_STA_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MktTrnsDate)
                .HasColumnName("MKT_TRNS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevTrnsDate)
                .HasColumnName("REV_TRNS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RevenueSeqNo)
                .HasColumnName("REVENUE_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StaTrnsDate)
                .HasColumnName("STA_TRNS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);
        });
	}
}
