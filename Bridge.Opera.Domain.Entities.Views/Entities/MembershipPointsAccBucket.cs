namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipPointsAccBucket
{
    public string BucketType { get; set; }
    public decimal? MembershipTrxId { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? NameId { get; set; }
    public string MembershipType { get; set; }
    public decimal? MembershipPointsSeqno { get; set; }
    public string Resort { get; set; }
    public decimal? MaxBucketSize { get; set; }
    public decimal? MinPropertiesReq { get; set; }
    public decimal? BucketQuantity { get; set; }
    public decimal? BucketQtyUsed { get; set; }
    public decimal? BucketPoints { get; set; }
    public decimal? Points { get; set; }
    public decimal? DaysFromEnroll { get; set; }
    public string PointsRatioPercentYn { get; set; }
    public string PointsRatioRoundingFlg { get; set; }
    public string RtcYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipPointsAccBucket>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_POINTS_ACC_BUCKET");

            entity.Property(e => e.BucketPoints)
                .HasColumnName("BUCKET_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BucketQtyUsed)
                .HasColumnName("BUCKET_QTY_USED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BucketQuantity)
                .HasColumnName("BUCKET_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BucketType)
                .HasColumnName("BUCKET_TYPE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.DaysFromEnroll)
                .HasColumnName("DAYS_FROM_ENROLL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxBucketSize)
                .HasColumnName("MAX_BUCKET_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipPointsSeqno)
                .HasColumnName("MEMBERSHIP_POINTS_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinPropertiesReq)
                .HasColumnName("MIN_PROPERTIES_REQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRatioPercentYn)
                .HasColumnName("POINTS_RATIO_PERCENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PointsRatioRoundingFlg)
                .HasColumnName("POINTS_RATIO_ROUNDING_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RtcYn)
                .HasColumnName("RTC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
