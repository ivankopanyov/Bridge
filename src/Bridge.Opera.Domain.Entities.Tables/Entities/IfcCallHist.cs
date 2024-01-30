namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcCallHist
{
    public string? Resort { get; set; }
    public decimal? RowId { get; set; }
    public string? RoomNum { get; set; }
    public string? LineNum { get; set; }
    public string? Type { get; set; }
    public string? Register { get; set; }
    public decimal? Units { get; set; }
    public decimal? Price { get; set; }
    public string? Dc { get; set; }
    public string? Cashier { get; set; }
    public string? TrunkId { get; set; }
    public string? GuestName { get; set; }
    public DateTime? CallTime { get; set; }
    public string? DialedDigits { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? PostDate { get; set; }
    public string? CheckNum { get; set; }
    public string? Supplement { get; set; }
    public decimal? Duration { get; set; }
    public decimal? TrxNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcCallHist>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_CALL_HIST");

            entity.HasIndex(e => new { e.Resort, e.Type, e.LineNum })
                .HasName("IFC_CALLHIST_RESTYPLN_IDX");

            entity.Property(e => e.CallTime)
                .HasColumnName("CALL_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Cashier)
                .HasColumnName("CASHIER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CheckNum)
                .HasColumnName("CHECK_NUM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Dc)
                .IsRequired()
                .HasColumnName("DC")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DialedDigits)
                .HasColumnName("DIALED_DIGITS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LineNum)
                .IsRequired()
                .HasColumnName("LINE_NUM")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Register)
                .HasColumnName("REGISTER")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNum)
                .HasColumnName("ROOM_NUM")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RowId)
                .HasColumnName("ROW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Supplement)
                .HasColumnName("SUPPLEMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrunkId)
                .HasColumnName("TRUNK_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Units)
                .HasColumnName("UNITS")
                .HasColumnType("NUMBER");
        });
	}
}
