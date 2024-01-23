namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Awards
{
    public Awards()
    {
        AwardRequests = new HashSet<AwardRequests>();
    }

    public decimal AwardSeqId { get; set; }
    public string Resort { get; set; }
    public string AwardCode { get; set; }
    public string Mpcode { get; set; }
    public string AwardDesc { get; set; }
    public decimal? AwardQty { get; set; }
    public decimal? AwardMiles { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string NumberRequiredType { get; set; }
    public string IsPackage { get; set; }
    public string IsUpgrade { get; set; }
    public string HotelCategory { get; set; }
    public string IsGift { get; set; }
    public string DefaultYn { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual MarketingPrograms MarketingPrograms { get; set; }
    public virtual ICollection<AwardRequests> AwardRequests { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Awards>(entity =>
        {
            entity.HasKey(e => e.AwardSeqId)
                .HasName("AWARDS_PK");

            entity.ToTable("AWARDS");

            entity.HasIndex(e => new { e.Resort, e.AwardCode })
                .HasName("AWARDS_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.Mpcode })
                .HasName("AWARDS_FK_I");

            entity.Property(e => e.AwardSeqId)
                .HasColumnName("AWARD_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardCode)
                .IsRequired()
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardDesc)
                .HasColumnName("AWARD_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardMiles)
                .HasColumnName("AWARD_MILES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardQty)
                .HasColumnName("AWARD_QTY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HotelCategory)
                .HasColumnName("HOTEL_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IsGift)
                .HasColumnName("IS_GIFT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IsPackage)
                .HasColumnName("IS_PACKAGE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IsUpgrade)
                .HasColumnName("IS_UPGRADE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Mpcode)
                .HasColumnName("MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NumberRequiredType)
                .HasColumnName("NUMBER_REQUIRED_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(MarketingPrograms)))
				entity.Ignore(e => e.MarketingPrograms);
			else
	            entity.HasOne(d => d.MarketingPrograms)
	                .WithMany(p => p.Awards)
	                .HasForeignKey(d => new { d.Resort, d.Mpcode })
	                .HasConstraintName("AWARDS_FK");
        
			if (!types.Contains(typeof(AwardRequests)))
				entity.Ignore(e => e.AwardRequests);
		});
	}
}
