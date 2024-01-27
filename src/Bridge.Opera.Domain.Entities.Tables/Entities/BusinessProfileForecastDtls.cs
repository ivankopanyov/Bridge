namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BusinessProfileForecastDtls
{
    public decimal ProfileId { get; set; }
    public string ForecastType { get; set; }
    public string Period { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? RoomAvgrate { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string PeriodCode { get; set; }
    public DateTime? PeriodStart { get; set; }
    public DateTime? PeriodEnd { get; set; }
    public byte? LaptopChange { get; set; }
    public string Resort { get; set; }
    public string ForecastSplitMode { get; set; }

    public virtual BusinessProfile Profile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BusinessProfileForecastDtls>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BUSINESS$PROFILE_FORECAST_DTLS");

            entity.HasIndex(e => new { e.ProfileId, e.ForecastType, e.PeriodCode, e.Resort, e.ForecastSplitMode })
                .HasName("BPFD_UK")
                .IsUnique();

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForecastSplitMode)
                .HasColumnName("FORECAST_SPLIT_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ForecastType)
                .IsRequired()
                .HasColumnName("FORECAST_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Period)
                .HasColumnName("PERIOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PeriodCode)
                .IsRequired()
                .HasColumnName("PERIOD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PeriodEnd)
                .HasColumnName("PERIOD_END")
                .HasColumnType("DATE");

            entity.Property(e => e.PeriodStart)
                .HasColumnName("PERIOD_START")
                .HasColumnType("DATE");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomAvgrate)
                .HasColumnName("ROOM_AVGRATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(BusinessProfile)))
				entity.Ignore(e => e.Profile);
			else
	            entity.HasOne(d => d.Profile)
	                .WithMany()
	                .HasForeignKey(d => d.ProfileId)
	                .HasConstraintName("BPFD_BP_FK");
        });
	}
}
