namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortRateCategory
{
    public string? Resort { get; set; }
    public string? RateCategory { get; set; }
    public string? Descr { get; set; }
    public string? RateClass { get; set; }
    public decimal? SellSequence { get; set; }
    public string? RateTier { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? DisplayDefaultYn { get; set; }
    public string? DisplaySet { get; set; }
    public string? ExportBucketCode { get; set; }

    public virtual ResortRateClasses R { get; set; }
    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortRateCategory>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCategory })
                .HasName("RESORT_RATE_CATEGORY_PK");

            entity.ToTable("RESORT_RATE_CATEGORY");

            entity.HasIndex(e => new { e.Resort, e.RateClass })
                .HasName("RESORT_RATE_CATEGORY_FK");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Descr)
                .HasColumnName("DESCR")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayDefaultYn)
                .HasColumnName("DISPLAY_DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySet)
                .HasColumnName("DISPLAY_SET")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportBucketCode)
                .HasColumnName("EXPORT_BUCKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateClass)
                .IsRequired()
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateTier)
                .HasColumnName("RATE_TIER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ResortRateCategory)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESORT_FK8");

			if (!types.Contains(typeof(ResortRateClasses)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.ResortRateCategory)
	                .HasForeignKey(d => new { d.Resort, d.RateClass })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESOST_RATE_CATEGORY_FK");
        });
	}
}
