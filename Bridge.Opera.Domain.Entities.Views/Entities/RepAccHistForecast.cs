namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepAccHistForecast
{
    public decimal? LEVEL { get; set; }
    public decimal? MasterAccountId { get; set; }
    public string MasterAccountName { get; set; }
    public decimal? AccountNameId { get; set; }
    public string AccountName { get; set; }
    public string AccountName2 { get; set; }
    public string AccountName3 { get; set; }
    public string Address { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
    public string Keyword { get; set; }
    public string Priority { get; set; }
    public string AccountType { get; set; }
    public string BusinessSegment { get; set; }
    public string Territory { get; set; }
    public string OwnerName { get; set; }
    public string OwnerCode { get; set; }
    public string Property { get; set; }
    public string PropertyName { get; set; }
    public string PropertyCity { get; set; }
    public decimal? IndRoomNights { get; set; }
    public decimal? IndRoomRevenue { get; set; }
    public decimal? IndFbRevenue { get; set; }
    public decimal? IndMiscRevenue { get; set; }
    public decimal? IndTotalRevenue { get; set; }
    public decimal? BlkRoomNights { get; set; }
    public decimal? BlkRoomRevenue { get; set; }
    public decimal? BlkFbRevenue { get; set; }
    public decimal? BlkMiscRevenue { get; set; }
    public decimal? BlkTotalRevenue { get; set; }
    public decimal? TotalRoomNights { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalFbRevenue { get; set; }
    public decimal? TotalMiscRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepAccHistForecast>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ACC_HIST_FORECAST");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountName2)
                .HasColumnName("ACCOUNT_NAME2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountName3)
                .HasColumnName("ACCOUNT_NAME3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNameId)
                .HasColumnName("ACCOUNT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BlkFbRevenue)
                .HasColumnName("BLK_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkMiscRevenue)
                .HasColumnName("BLK_MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRoomNights)
                .HasColumnName("BLK_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRoomRevenue)
                .HasColumnName("BLK_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkTotalRevenue)
                .HasColumnName("BLK_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessSegment)
                .HasColumnName("BUSINESS_SEGMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IndFbRevenue)
                .HasColumnName("IND_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndMiscRevenue)
                .HasColumnName("IND_MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomNights)
                .HasColumnName("IND_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomRevenue)
                .HasColumnName("IND_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndTotalRevenue)
                .HasColumnName("IND_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Keyword)
                .HasColumnName("KEYWORD")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LEVEL)
                .HasColumnName("L_E_V_E_L")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterAccountId)
                .HasColumnName("MASTER_ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterAccountName)
                .HasColumnName("MASTER_ACCOUNT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OwnerCode)
                .HasColumnName("OWNER_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OwnerName)
                .HasColumnName("OWNER_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Property)
                .HasColumnName("PROPERTY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCity)
                .HasColumnName("PROPERTY_CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropertyName)
                .HasColumnName("PROPERTY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Territory)
                .HasColumnName("TERRITORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotalFbRevenue)
                .HasColumnName("TOTAL_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMiscRevenue)
                .HasColumnName("TOTAL_MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomNights)
                .HasColumnName("TOTAL_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
