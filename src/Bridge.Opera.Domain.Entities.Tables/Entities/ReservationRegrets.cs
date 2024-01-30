namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationRegrets
{
    public string? Resort { get; set; }
    public decimal? ReservationRegretId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public decimal? Nights { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string? MarketCode { get; set; }
    public string? TurnawayCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? Comments { get; set; }
    public decimal? CallHeaderId { get; set; }
    public decimal? RequestId { get; set; }
    public string? Country { get; set; }
    public string? Region { get; set; }
    public string? ZipCode { get; set; }
    public string? City { get; set; }
    public string? District { get; set; }
    public string? State { get; set; }
    public DateTime? TruncCreatedDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string? YmCode { get; set; }
    public string? CustomerValue { get; set; }

    public virtual Name Name { get; set; }
    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationRegrets>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESERVATION_REGRETS");

            entity.HasIndex(e => e.CallHeaderId)
                .HasName("RESERVATION_REGRETS_IND3");

            entity.HasIndex(e => e.MarketCode)
                .HasName("RESV_REGRETS_MARKET_CODE_IDX");

            entity.HasIndex(e => e.NameId)
                .HasName("RESV_REGRETS_NAME_ID_IDX");

            entity.HasIndex(e => e.RequestId)
                .HasName("RESERVATION_REGRETS_IND4");

            entity.HasIndex(e => new { e.Resort, e.ArrivalDate })
                .HasName("RESERVATION_REGRETS_IND1");

            entity.HasIndex(e => new { e.Resort, e.ReservationRegretId })
                .HasName("RESERVATION_REGRETS_RGR_ID_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("RESERVATION_REGRETS_IND2");

            entity.HasIndex(e => new { e.Resort, e.TurnawayCode })
                .HasName("RESERVATION_REGRETS_FK3_I");

            entity.HasIndex(e => new { e.TruncCreatedDate, e.Resort })
                .HasName("RESERVATION_REGRETS_IND5");

            entity.HasIndex(e => new { e.Resort, e.DepartureDate, e.ArrivalDate, e.NoOfRooms })
                .HasName("RESV_REGRETS_DEP_IDX");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CallHeaderId)
                .HasColumnName("CALL_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CustomerValue)
                .HasColumnName("CUSTOMER_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.District)
                .HasColumnName("DISTRICT")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationRegretId)
                .HasColumnName("RESERVATION_REGRET_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TruncCreatedDate)
                .HasColumnName("TRUNC_CREATED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TurnawayCode)
                .IsRequired()
                .HasColumnName("TURNAWAY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YmCode)
                .HasColumnName("YM_CODE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany()
	                .HasForeignKey(d => d.NameId)
	                .HasConstraintName("RESERVATION_REGRETS_FK2");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("RESERVATION_REGRETS_FK1");
        });
	}
}
