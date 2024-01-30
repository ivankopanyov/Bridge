namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTrxBucketLink
{
    public decimal? BucketId { get; set; }
    public decimal? MembershipTrxId { get; set; }
    public decimal? BucketQuantity { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxBucketLink>(entity =>
        {
            entity.HasKey(e => new { e.BucketId, e.MembershipTrxId })
                .HasName("MTK_PK");

            entity.ToTable("MEMBERSHIP_TRX_BUCKET_LINK");

            entity.HasIndex(e => e.MembershipTrxId)
                .HasName("MEM_TRX_BKT_LINK_IDX1");

            entity.Property(e => e.BucketId)
                .HasColumnName("BUCKET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BucketQuantity)
                .HasColumnName("BUCKET_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
