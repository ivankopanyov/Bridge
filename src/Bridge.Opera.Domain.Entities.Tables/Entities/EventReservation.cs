namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventReservation
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? EventId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? BookId { get; set; }
    public decimal? PkgId { get; set; }
    public string? Room { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public string? SetupCode { get; set; }
    public string? SetupDesc { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public decimal? Attendees { get; set; }
    public string? RevenueType { get; set; }
    public string? Ratecode { get; set; }
    public string? FixedRateYn { get; set; }
    public string? HourlyYn { get; set; }
    public decimal? RateAmount { get; set; }
    public string? SharedYn { get; set; }
    public string? DontMoveYn { get; set; }
    public string? NoisyYn { get; set; }
    public decimal? DiscountAmount { get; set; }
    public decimal? DiscountPercentage { get; set; }
    public string? DiscountReasonCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? RoomResort { get; set; }
    public string? RateType { get; set; }
    public string? MinimumRevenueYn { get; set; }
    public decimal? MinimumRevenue { get; set; }
    public decimal? RentalAmount { get; set; }
    public string? IncSetupInHourlyRateYn { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual GemEvent Event { get; set; }
    public virtual RoomRates R { get; set; }
    public virtual RoomSetup RoomSetup { get; set; }
    public virtual EventReservationShare EventReservationShare { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventReservation>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("ER_PK");

            entity.ToTable("EVENT$RESERVATION");

            entity.HasIndex(e => e.EventId)
                .HasName("ER_GE_IDX");

            entity.HasIndex(e => new { e.BookId, e.Resort })
                .HasName("ER_AH_FK_IDX");

            entity.HasIndex(e => new { e.RoomResort, e.Room })
                .HasName("ER_DATES_ROOM_FBI")
                .HasFilter("\"BEGIN_DATE\"-NVL(\"SETUP_TIME\",0)/1440");

            entity.HasIndex(e => new { e.RoomResort, e.Room, e.Ratecode })
                .HasName("ER_SPAR_IDX");

            entity.HasIndex(e => new { e.RoomResort, e.Room, e.SetupCode })
                .HasName("ER_SPAS_IDX");

            entity.HasIndex(e => new { e.BeginDate, e.EndDate, e.RoomResort, e.Room })
                .HasName("ER_DATES_RESROOM_IDX");

            entity.HasIndex(e => new { e.RoomResort, e.BeginDate, e.EndDate, e.Room })
                .HasName("ER_DATES_ROOM_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountAmount)
                .HasColumnName("DISCOUNT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPercentage)
                .HasColumnName("DISCOUNT_PERCENTAGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountReasonCode)
                .HasColumnName("DISCOUNT_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DontMoveYn)
                .HasColumnName("DONT_MOVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FixedRateYn)
                .HasColumnName("FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HourlyYn)
                .HasColumnName("HOURLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.IncSetupInHourlyRateYn)
                .HasColumnName("INC_SETUP_IN_HOURLY_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumRevenue)
                .HasColumnName("MINIMUM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumRevenueYn)
                .HasColumnName("MINIMUM_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoisyYn)
                .HasColumnName("NOISY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateType)
                .HasColumnName("RATE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Ratecode)
                .HasColumnName("RATECODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RentalAmount)
                .HasColumnName("RENTAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueType)
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetupCode)
                .HasColumnName("SETUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetupDesc)
                .HasColumnName("SETUP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.EventReservation)
	                .HasForeignKey(d => d.EventId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ER_GE_FK");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.EventReservation)
	                .HasForeignKey(d => new { d.BookId, d.Resort })
	                .HasConstraintName("ER_AH_FK");

			if (!types.Contains(typeof(RoomRates)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.EventReservation)
	                .HasForeignKey(d => new { d.RoomResort, d.Room, d.Ratecode })
	                .HasConstraintName("ER_SPAR_FK");

			if (!types.Contains(typeof(RoomSetup)))
				entity.Ignore(e => e.RoomSetup);
			else
	            entity.HasOne(d => d.RoomSetup)
	                .WithMany(p => p.EventReservation)
	                .HasForeignKey(d => new { d.RoomResort, d.Room, d.SetupCode })
	                .HasConstraintName("ER_SPAS_FK");

            if (!types.Contains(typeof(EventReservationShare)))
                entity.Ignore(e => e.EventReservationShare);
        });
	}
}
