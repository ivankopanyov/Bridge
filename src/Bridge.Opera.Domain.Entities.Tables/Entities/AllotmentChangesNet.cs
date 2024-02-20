namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentChangesNet
{
    public decimal? AllotChangeNetId { get; set; }
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? Roomnights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public string? BookingStatus { get; set; }
    public string? MainSrepResort { get; set; }
    public decimal? MainSrep { get; set; }
    public string? RmsSrepResort { get; set; }
    public decimal? RmsSrep { get; set; }
    public string? CatSrepResort { get; set; }
    public decimal? CatSrep { get; set; }
    public decimal? LaptopChange { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? FoodRevenueTax { get; set; }
    public decimal? OtherRevenueTax { get; set; }
    public decimal? TotalRevenueTax { get; set; }
    public decimal? NonRevenueTax { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? FcRoomRevenue { get; set; }
    public decimal? FcFoodRevenue { get; set; }
    public decimal? FcOtherRevenue { get; set; }
    public decimal? FcTotalRevenue { get; set; }
    public decimal? FcNonRevenue { get; set; }
    public decimal? FcRoomRevenueTax { get; set; }
    public decimal? FcFoodRevenueTax { get; set; }
    public decimal? FcOtherRevenueTax { get; set; }
    public decimal? FcTotalRevenueTax { get; set; }
    public decimal? FcNonRevenueTax { get; set; }
    public string? CurrencyCode { get; set; }
    public DateTime? ExchangeDate { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentChangesNet>(entity =>
        {
            entity.HasKey(e => e.AllotChangeNetId)
                .HasName("ALC_NET_PK");

            entity.ToTable("ALLOTMENT_CHANGES_NET");

            entity.HasIndex(e => e.InsertDate)
                .HasName("ALC_NET_INSERT_DATE_IDX");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("ALC_AH_ID_NET_IDX");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.StayDate, e.Resort })
                .HasName("ALC_NET_DATE_RESORT_ID");

            entity.Property(e => e.AllotChangeNetId)
                .HasColumnName("ALLOT_CHANGE_NET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatSrep)
                .HasColumnName("CAT_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatSrepResort)
                .HasColumnName("CAT_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeDate)
                .HasColumnName("EXCHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FcFoodRevenue)
                .HasColumnName("FC_FOOD_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcFoodRevenueTax)
                .HasColumnName("FC_FOOD_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcNonRevenue)
                .HasColumnName("FC_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcNonRevenueTax)
                .HasColumnName("FC_NON_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcOtherRevenue)
                .HasColumnName("FC_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcOtherRevenueTax)
                .HasColumnName("FC_OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcRoomRevenue)
                .HasColumnName("FC_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcRoomRevenueTax)
                .HasColumnName("FC_ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcTotalRevenue)
                .HasColumnName("FC_TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcTotalRevenueTax)
                .HasColumnName("FC_TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenueTax)
                .HasColumnName("FOOD_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MainSrep)
                .HasColumnName("MAIN_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MainSrepResort)
                .HasColumnName("MAIN_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueTax)
                .HasColumnName("NON_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueTax)
                .HasColumnName("OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsSrep)
                .HasColumnName("RMS_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsSrepResort)
                .HasColumnName("RMS_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Roomnights)
                .HasColumnName("ROOMNIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRevenueTax)
                .HasColumnName("TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.AllotmentChangesNet)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALC_AH_NET_FK");
        });
	}
}
