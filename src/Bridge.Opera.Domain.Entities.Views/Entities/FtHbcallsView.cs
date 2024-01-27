namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FtHbcallsView
{
    public string Resort { get; set; }
    public string RoomNum { get; set; }
    public string LineNum { get; set; }
    public string Type { get; set; }
    public decimal? Price { get; set; }
    public string TrxCode { get; set; }
    public DateTime? CallTime { get; set; }
    public string DialedDigits { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? PostDate { get; set; }
    public string Supplement { get; set; }
    public string Duration { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FtHbcallsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FT_HBCALLS_VIEW");

            entity.Property(e => e.CallTime)
                .HasColumnName("CALL_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DialedDigits)
                .HasColumnName("DIALED_DIGITS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LineNum)
                .HasColumnName("LINE_NUM")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNum)
                .HasColumnName("ROOM_NUM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Supplement)
                .HasColumnName("SUPPLEMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(4)
                .IsUnicode(false);
        });
	}
}
