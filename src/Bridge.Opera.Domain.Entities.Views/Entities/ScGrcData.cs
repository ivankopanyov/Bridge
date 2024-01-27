namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScGrcData
{
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public string BookingStatus { get; set; }
    public DateTime ArrivalDate { get; set; }
    public DateTime DepartureDate { get; set; }
    public decimal? Owner { get; set; }
    public decimal? RoomsOwner { get; set; }
    public string AllotmentOrigion { get; set; }
    public string BookingType { get; set; }
    public int? SuperBlockId { get; set; }
    public string SuperBlockResort { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public decimal? OrderBy { get; set; }
    public string BaseCurrency { get; set; }
    public string Name { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? ContactId { get; set; }
    public decimal? AgentId { get; set; }
    public decimal? SourceId { get; set; }
    public string RoomMgrCode { get; set; }
    public string RateProtection { get; set; }
    public string NonCompete { get; set; }
    public string ConversionCode { get; set; }
    public string RankingCode { get; set; }
    public string NonCompeteCode { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? ContractQuantity { get; set; }
    public decimal? PickupQuantity { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScGrcData>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_GRC_DATA");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentId)
                .HasColumnName("AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentOrigion)
                .HasColumnName("ALLOTMENT_ORIGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BaseCurrency)
                .HasColumnName("BASE_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.BookingType)
                .HasColumnName("BOOKING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractQuantity)
                .HasColumnName("CONTRACT_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConversionCode)
                .HasColumnName("CONVERSION_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .IsUnicode(false);

            entity.Property(e => e.NonCompete)
                .HasColumnName("NON_COMPETE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NonCompeteCode)
                .HasColumnName("NON_COMPETE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupQuantity)
                .HasColumnName("PICKUP_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RankingCode)
                .HasColumnName("RANKING_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RateProtection)
                .HasColumnName("RATE_PROTECTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomMgrCode)
                .HasColumnName("ROOM_MGR_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RoomsOwner)
                .HasColumnName("ROOMS_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SuperBlockId).HasColumnName("SUPER_BLOCK_ID");

            entity.Property(e => e.SuperBlockResort)
                .HasColumnName("SUPER_BLOCK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
