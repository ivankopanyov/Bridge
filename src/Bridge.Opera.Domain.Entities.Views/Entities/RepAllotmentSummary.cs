namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepAllotmentSummary
{
    public string? AllotmentCode { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? RateCode { get; set; }
    public DateTime? D { get; set; }
    public decimal? Tosell { get; set; }
    public decimal? Pickup { get; set; }
    public decimal? Original { get; set; }
    public decimal? Change { get; set; }
    public decimal? Remain { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepAllotmentSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ALLOTMENT_SUMMARY");

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Change)
                .HasColumnName("CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.D).HasColumnType("DATE");

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

            entity.Property(e => e.Original)
                .HasColumnName("ORIGINAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Pickup)
                .HasColumnName("PICKUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Remain)
                .HasColumnName("REMAIN")
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
