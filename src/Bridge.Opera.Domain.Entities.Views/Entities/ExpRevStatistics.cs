namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpRevStatistics
{
    public decimal? ExportId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string PropertyCode { get; set; }
    public string ExportBucket1 { get; set; }
    public string ExportBucket2 { get; set; }
    public string ExportBucket3 { get; set; }
    public string ExportBucket4 { get; set; }
    public string ExportBucket5 { get; set; }
    public string ExportBucket6 { get; set; }
    public string ExportBucket7 { get; set; }
    public string ExportBucket8 { get; set; }
    public string ExportBucket9 { get; set; }
    public string ExportBucket10 { get; set; }
    public string ExportBucket11 { get; set; }
    public string ExportBucket12 { get; set; }
    public decimal? Revenue1 { get; set; }
    public decimal? Revenue2 { get; set; }
    public decimal? Revenue3 { get; set; }
    public decimal? Revenue4 { get; set; }
    public decimal? Revenue5 { get; set; }
    public decimal? Revenue6 { get; set; }
    public decimal? Revenue7 { get; set; }
    public decimal? Revenue8 { get; set; }
    public decimal? Revenue9 { get; set; }
    public decimal? Revenue10 { get; set; }
    public decimal? Revenue11 { get; set; }
    public decimal? Revenue12 { get; set; }
    public decimal? NetAmount1 { get; set; }
    public decimal? NetAmount2 { get; set; }
    public decimal? NetAmount3 { get; set; }
    public decimal? NetAmount4 { get; set; }
    public decimal? NetAmount5 { get; set; }
    public decimal? NetAmount6 { get; set; }
    public decimal? NetAmount7 { get; set; }
    public decimal? NetAmount8 { get; set; }
    public decimal? NetAmount9 { get; set; }
    public decimal? NetAmount10 { get; set; }
    public decimal? GrossAmount1 { get; set; }
    public decimal? GrossAmount2 { get; set; }
    public decimal? GrossAmount3 { get; set; }
    public decimal? GrossAmount4 { get; set; }
    public decimal? GrossAmount5 { get; set; }
    public decimal? GrossAmount6 { get; set; }
    public decimal? GrossAmount7 { get; set; }
    public decimal? GrossAmount8 { get; set; }
    public decimal? GrossAmount9 { get; set; }
    public decimal? GrossAmount10 { get; set; }
    public decimal? SingleOccRoom { get; set; }
    public decimal? MultiOccRoom { get; set; }
    public decimal? RoomAvail { get; set; }
    public string PropertyCurrencyCode { get; set; }
    public decimal? PropertyCurrencyDecimals { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpRevStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_REV_STATISTICS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportBucket1)
                .HasColumnName("EXPORT_BUCKET_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket10)
                .HasColumnName("EXPORT_BUCKET_10")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket11)
                .HasColumnName("EXPORT_BUCKET_11")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket12)
                .HasColumnName("EXPORT_BUCKET_12")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket2)
                .HasColumnName("EXPORT_BUCKET_2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket3)
                .HasColumnName("EXPORT_BUCKET_3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket4)
                .HasColumnName("EXPORT_BUCKET_4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket5)
                .HasColumnName("EXPORT_BUCKET_5")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket6)
                .HasColumnName("EXPORT_BUCKET_6")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket7)
                .HasColumnName("EXPORT_BUCKET_7")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket8)
                .HasColumnName("EXPORT_BUCKET_8")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket9)
                .HasColumnName("EXPORT_BUCKET_9")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount1)
                .HasColumnName("GROSS_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount10)
                .HasColumnName("GROSS_AMOUNT_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount2)
                .HasColumnName("GROSS_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount3)
                .HasColumnName("GROSS_AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount4)
                .HasColumnName("GROSS_AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount5)
                .HasColumnName("GROSS_AMOUNT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount6)
                .HasColumnName("GROSS_AMOUNT_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount7)
                .HasColumnName("GROSS_AMOUNT_7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount8)
                .HasColumnName("GROSS_AMOUNT_8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount9)
                .HasColumnName("GROSS_AMOUNT_9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiOccRoom)
                .HasColumnName("MULTI_OCC_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount1)
                .HasColumnName("NET_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount10)
                .HasColumnName("NET_AMOUNT_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount2)
                .HasColumnName("NET_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount3)
                .HasColumnName("NET_AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount4)
                .HasColumnName("NET_AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount5)
                .HasColumnName("NET_AMOUNT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount6)
                .HasColumnName("NET_AMOUNT_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount7)
                .HasColumnName("NET_AMOUNT_7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount8)
                .HasColumnName("NET_AMOUNT_8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount9)
                .HasColumnName("NET_AMOUNT_9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCurrencyCode)
                .HasColumnName("PROPERTY_CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCurrencyDecimals)
                .HasColumnName("PROPERTY_CURRENCY_DECIMALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue1)
                .HasColumnName("REVENUE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue10)
                .HasColumnName("REVENUE_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue11)
                .HasColumnName("REVENUE_11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue12)
                .HasColumnName("REVENUE_12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue2)
                .HasColumnName("REVENUE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue3)
                .HasColumnName("REVENUE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue4)
                .HasColumnName("REVENUE_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue5)
                .HasColumnName("REVENUE_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue6)
                .HasColumnName("REVENUE_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue7)
                .HasColumnName("REVENUE_7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue8)
                .HasColumnName("REVENUE_8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue9)
                .HasColumnName("REVENUE_9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomAvail)
                .HasColumnName("ROOM_AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccRoom)
                .HasColumnName("SINGLE_OCC_ROOM")
                .HasColumnType("NUMBER");
        });
	}
}
