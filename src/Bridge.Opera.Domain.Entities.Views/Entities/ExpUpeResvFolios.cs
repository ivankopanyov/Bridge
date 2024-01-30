namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeResvFolios
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string? FolioId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? FolioNo { get; set; }
    public string? FolioType { get; set; }
    public decimal? BillNo { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? NameId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? CashierId { get; set; }
    public string? CalcResvStatus { get; set; }
    public string? Channel { get; set; }
    public decimal? Persons { get; set; }
    public string? GuestCountry { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? ArNumber { get; set; }
    public decimal? PostitNo { get; set; }
    public string? MarketCode { get; set; }
    public decimal? RoomCategory { get; set; }
    public string? IsPermanentBillingYn { get; set; }
    public string? PermanentBillingId { get; set; }
    public string? InclInFoliosYn { get; set; }
    public string? InclInFinalFoliosYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeResvFolios>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_RESV_FOLIOS");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CalcResvStatus)
                .HasColumnName("CALC_RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioId)
                .HasColumnName("FOLIO_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestCountry)
                .HasColumnName("GUEST_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InclInFinalFoliosYn)
                .HasColumnName("INCL_IN_FINAL_FOLIOS_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InclInFoliosYn)
                .HasColumnName("INCL_IN_FOLIOS_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsPermanentBillingYn)
                .HasColumnName("IS_PERMANENT_BILLING_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermanentBillingId)
                .HasColumnName("PERMANENT_BILLING_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostitNo)
                .HasColumnName("POSTIT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
