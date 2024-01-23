namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpAllotmentView
{
    public decimal AllotmentHeaderId { get; set; }
    public string AllotmentCode { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public string GuaranteeCode { get; set; }
    public string RateCode { get; set; }
    public decimal? MasterNameId { get; set; }
    public decimal? AvgPeoplePerRoom { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime AllotmentDate { get; set; }
    public string InsertUser { get; set; }
    public DateTime? InvCutoffDate { get; set; }
    public decimal? InvCutoffDays { get; set; }
    public decimal? Tosell { get; set; }
    public decimal? Init { get; set; }
    public decimal? Pickup { get; set; }
    public decimal? Reduced { get; set; }
    public string BookingStatus { get; set; }
    public decimal? RateAmount1 { get; set; }
    public decimal? RateAmount2 { get; set; }
    public decimal? RateAmount3 { get; set; }
    public decimal? RateAmount4 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpAllotmentView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ALLOTMENT_VIEW");

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgPeoplePerRoom)
                .HasColumnName("AVG_PEOPLE_PER_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Init)
                .HasColumnName("INIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

            entity.Property(e => e.InvCutoffDate)
                .HasColumnName("INV_CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvCutoffDays)
                .HasColumnName("INV_CUTOFF_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterNameId)
                .HasColumnName("MASTER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Pickup)
                .HasColumnName("PICKUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount1)
                .HasColumnName("RATE_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount2)
                .HasColumnName("RATE_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount3)
                .HasColumnName("RATE_AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount4)
                .HasColumnName("RATE_AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Reduced)
                .HasColumnName("REDUCED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tosell)
                .HasColumnName("TOSELL")
                .HasColumnType("NUMBER");
        });
	}
}
