namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateBuckets
{
    public RateBuckets()
    {
        RateHeader = new HashSet<RateHeader>();
    }

    public string? Resort { get; set; }
    public string? RateBucketCode { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<RateHeader> RateHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateBuckets>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateBucketCode })
                .HasName("RATE_BUCKETS_PK");

            entity.ToTable("RATE_BUCKETS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateBucketCode)
                .HasColumnName("RATE_BUCKET_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(RateHeader)))
				entity.Ignore(e => e.RateHeader);
		});
	}
}
