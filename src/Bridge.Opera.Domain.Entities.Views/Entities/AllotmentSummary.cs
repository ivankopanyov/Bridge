namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AllotmentSummary
{
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? AllotmentCode { get; set; }
    public string? Description { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? RateCode { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? NewStatus { get; set; }
    public string? StatusDesc { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? InsertUser { get; set; }
    public decimal? Tosell { get; set; }
    public decimal? Init { get; set; }
    public decimal? Pickup { get; set; }
    public decimal? Reduced { get; set; }
    public decimal? Blocksize { get; set; }
    public decimal? Avail { get; set; }
    public decimal? Persons { get; set; }
    public DateTime? Cutoff { get; set; }
    public decimal? MasterNameId { get; set; }
    public string? BookingStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ALLOTMENT_SUMMARY");

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

            entity.Property(e => e.Avail)
                .HasColumnName("AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Blocksize)
                .HasColumnName("BLOCKSIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Cutoff)
                .HasColumnName("CUTOFF")
                .HasColumnType("DATE");

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

            entity.Property(e => e.MasterNameId)
                .HasColumnName("MASTER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewStatus)
                .HasColumnName("NEW_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Pickup)
                .HasColumnName("PICKUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Reduced)
                .HasColumnName("REDUCED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusDesc)
                .HasColumnName("STATUS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Tosell)
                .HasColumnName("TOSELL")
                .HasColumnType("NUMBER");
        });
	}
}
