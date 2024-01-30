namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomRates
{
    public RoomRates()
    {
        EventReservation = new HashSet<EventReservation>();
    }

    public string? Resort { get; set; }
    public string? Room { get; set; }
    public decimal? RatecodeId { get; set; }
    public string? RateCode { get; set; }
    public decimal? Rate { get; set; }
    public string? DefaultYn { get; set; }
    public string? HourlyYn { get; set; }
    public string? RevenueType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? RateType { get; set; }
    public string? MinimumRevenueYn { get; set; }

    public virtual Room R { get; set; }
    public virtual GemTranslation Ratecode { get; set; }
    public virtual ICollection<EventReservation> EventReservation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomRates>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room, e.RateCode })
                .HasName("RR_PK");

            entity.ToTable("ROOM$RATES");

            entity.HasIndex(e => e.RatecodeId)
                .HasName("SPAR_RATEID_IDX");

            entity.HasIndex(e => e.RevenueType)
                .HasName("SPAR_REVTYPE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.HourlyYn)
                .HasColumnName("HOURLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MinimumRevenueYn)
                .HasColumnName("MINIMUM_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Rate)
                .HasColumnName("RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateType)
                .HasColumnName("RATE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'PR'");

            entity.Property(e => e.RatecodeId)
                .HasColumnName("RATECODE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(GemTranslation)))
				entity.Ignore(e => e.Ratecode);
			else
	            entity.HasOne(d => d.Ratecode)
	                .WithMany(p => p.RoomRates)
	                .HasForeignKey(d => d.RatecodeId)
	                .HasConstraintName("SPAR_GT_FK");

			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RoomRates)
	                .HasForeignKey(d => new { d.Resort, d.Room })
	                .HasConstraintName("SPAR_ROOM_FK");
        
			if (!types.Contains(typeof(EventReservation)))
				entity.Ignore(e => e.EventReservation);
		});
	}
}
