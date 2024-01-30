namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofStatisticExport
{
    public string? TrxCode { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? SingleOccRoom { get; set; }
    public decimal? MultiOccRoom { get; set; }
    public decimal? RoomAvail { get; set; }
    public decimal? TotalResortRooms { get; set; }
    public string? BofCode1 { get; set; }
    public string? BofCode2 { get; set; }
    public string? BofCode3 { get; set; }
    public string? BofCode4 { get; set; }
    public string? BofCode5 { get; set; }
    public decimal? BofCode6 { get; set; }
    public decimal? BofCode7 { get; set; }
    public decimal? BofCode8 { get; set; }
    public decimal? BofCode9 { get; set; }
    public decimal? BofCode10 { get; set; }
    public DateTime? BofCode11 { get; set; }
    public DateTime? BofCode12 { get; set; }
    public DateTime? BofCode13 { get; set; }
    public DateTime? BofCode14 { get; set; }
    public DateTime? BofCode15 { get; set; }
    public string? BofCode16 { get; set; }
    public string? BofCode17 { get; set; }
    public string? BofCode18 { get; set; }
    public string? BofCode19 { get; set; }
    public string? BofCode20 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofStatisticExport>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_STATISTIC_EXPORT");

            entity.Property(e => e.BofCode1)
                .HasColumnName("BOF_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode10)
                .HasColumnName("BOF_CODE10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode11)
                .HasColumnName("BOF_CODE11")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode12)
                .HasColumnName("BOF_CODE12")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode13)
                .HasColumnName("BOF_CODE13")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode14)
                .HasColumnName("BOF_CODE14")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode15)
                .HasColumnName("BOF_CODE15")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode16)
                .HasColumnName("BOF_CODE16")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode17)
                .HasColumnName("BOF_CODE17")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode18)
                .HasColumnName("BOF_CODE18")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode19)
                .HasColumnName("BOF_CODE19")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode2)
                .HasColumnName("BOF_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode20)
                .HasColumnName("BOF_CODE20")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode3)
                .HasColumnName("BOF_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode4)
                .HasColumnName("BOF_CODE4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode5)
                .HasColumnName("BOF_CODE5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode6)
                .HasColumnName("BOF_CODE6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode7)
                .HasColumnName("BOF_CODE7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode8)
                .HasColumnName("BOF_CODE8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode9)
                .HasColumnName("BOF_CODE9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiOccRoom)
                .HasColumnName("MULTI_OCC_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomAvail)
                .HasColumnName("ROOM_AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccRoom)
                .HasColumnName("SINGLE_OCC_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalResortRooms)
                .HasColumnName("TOTAL_RESORT_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
