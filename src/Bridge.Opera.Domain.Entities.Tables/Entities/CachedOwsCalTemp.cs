namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CachedOwsCalTemp
{
    public string ChannelCode { get; set; }
    public string Resort { get; set; }
    public DateTime StayDate { get; set; }
    public decimal Adults { get; set; }
    public decimal Children { get; set; }
    public decimal Children1 { get; set; }
    public decimal Children2 { get; set; }
    public decimal Children3 { get; set; }
    public string RateCodes { get; set; }
    public string RoomTypes { get; set; }
    public decimal NoRooms { get; set; }
    public decimal CompanyId { get; set; }
    public decimal? Amount { get; set; }
    public string RestrictionTypes { get; set; }
    public DateTime LastUpdateTime { get; set; }
    public decimal LastUpdateUser { get; set; }
    public string RateDescription { get; set; }
    public string CurrencyCode { get; set; }
    public decimal Nights { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CachedOwsCalTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CACHED$_OWS_CAL_TEMP");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChannelCode)
                .IsRequired()
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children1)
                .HasColumnName("CHILDREN1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children2)
                .HasColumnName("CHILDREN2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children3)
                .HasColumnName("CHILDREN3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdateTime)
                .HasColumnName("LAST_UPDATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.LastUpdateUser)
                .HasColumnName("LAST_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("1 ");

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCodes)
                .IsRequired()
                .HasColumnName("RATE_CODES")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.RateDescription)
                .HasColumnName("RATE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionTypes)
                .HasColumnName("RESTRICTION_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomTypes)
                .IsRequired()
                .HasColumnName("ROOM_TYPES")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");
        });
	}
}
