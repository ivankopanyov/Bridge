namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipRevenueTypes
{
    public string MembershipRevenueType { get; set; }
    public string Description { get; set; }
    public string Label { get; set; }
    public string MembershipPoints { get; set; }
    public string FrequentFlyerPoints { get; set; }
    public string TierPoints { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? OrderBy { get; set; }
    public string ExportBucketCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipRevenueTypes>(entity =>
        {
            entity.HasKey(e => e.MembershipRevenueType)
                .HasName("MEMB__REVENUE_TYPES_PK");

            entity.ToTable("MEMBERSHIP_REVENUE_TYPES");

            entity.HasIndex(e => e.ExportBucketCode)
                .HasName("MEM_REV_TYPE_BUCKET_CODE_IDX");

            entity.Property(e => e.MembershipRevenueType)
                .HasColumnName("MEMBERSHIP_REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucketCode)
                .HasColumnName("EXPORT_BUCKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FrequentFlyerPoints)
                .HasColumnName("FREQUENT_FLYER_POINTS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipPoints)
                .HasColumnName("MEMBERSHIP_POINTS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TierPoints)
                .HasColumnName("TIER_POINTS")
                .HasMaxLength(1)
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
