namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTrxBucket
{
    public decimal BucketId { get; set; }
    public decimal NameId { get; set; }
    public string MembershipType { get; set; }
    public decimal? MembershipPointsSeqno { get; set; }
    public string ChainCode { get; set; }
    public decimal? MaxBucketSize { get; set; }
    public string BucketType { get; set; }
    public string BucketStatus { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? BucketTrxId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxBucket>(entity =>
        {
            entity.HasKey(e => e.BucketId)
                .HasName("MTB_PK");

            entity.ToTable("MEMBERSHIP_TRX_BUCKET");

            entity.HasIndex(e => e.NameId)
                .HasName("MEM_TRX_BKT_IND1");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType, e.MembershipPointsSeqno })
                .HasName("MEM_TRX_BKT_IND2");

            entity.Property(e => e.BucketId)
                .HasColumnName("BUCKET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BucketStatus)
                .HasColumnName("BUCKET_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BucketTrxId)
                .HasColumnName("BUCKET_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BucketType)
                .HasColumnName("BUCKET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxBucketSize)
                .HasColumnName("MAX_BUCKET_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipPointsSeqno)
                .HasColumnName("MEMBERSHIP_POINTS_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
