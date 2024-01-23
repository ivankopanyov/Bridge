namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateCodesView
{
    public string RateCode { get; set; }
    public string Description { get; set; }
    public DateTime BeginBookingDate { get; set; }
    public DateTime? EndBookingDate { get; set; }
    public decimal? DisplaySeq { get; set; }
    public string GdsHost { get; set; }
    public string ChannelType { get; set; }
    public string GrcGdsHost { get; set; }
    public string GrcGdsRateCode { get; set; }
    public string GrcGdsRateCategory { get; set; }
    public string GrcGdsRateLevel { get; set; }
    public string GrcNegRateCode { get; set; }
    public decimal? SortCol1 { get; set; }
    public string ExternalValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateCodesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_CODES_VIEW");

            entity.Property(e => e.BeginBookingDate)
                .HasColumnName("BEGIN_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndBookingDate)
                .HasColumnName("END_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExternalValue)
                .HasColumnName("EXTERNAL_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GrcGdsHost)
                .HasColumnName("GRC_GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GrcGdsRateCategory)
                .HasColumnName("GRC_GDS_RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GrcGdsRateCode)
                .HasColumnName("GRC_GDS_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GrcGdsRateLevel)
                .HasColumnName("GRC_GDS_RATE_LEVEL")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.GrcNegRateCode)
                .HasColumnName("GRC_NEG_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SortCol1)
                .HasColumnName("SORT_COL1")
                .HasColumnType("NUMBER");
        });
	}
}
