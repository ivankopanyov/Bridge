namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TurnawayStatView
{
    public string? MarketCode { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public decimal? Reason1 { get; set; }
    public decimal? Reason2 { get; set; }
    public decimal? Reason3 { get; set; }
    public decimal? Reason4 { get; set; }
    public decimal? Reason5 { get; set; }
    public decimal? Reason6 { get; set; }
    public decimal? Reason7 { get; set; }
    public decimal? Reason8 { get; set; }
    public decimal? Reason9 { get; set; }
    public decimal? Reason10 { get; set; }
    public decimal? Reason11 { get; set; }
    public decimal? Reason12 { get; set; }
    public decimal? Reason13 { get; set; }
    public decimal? Reason14 { get; set; }
    public decimal? Reason15 { get; set; }
    public decimal? Reason16 { get; set; }
    public decimal? Reason17 { get; set; }
    public decimal? Reason18 { get; set; }
    public decimal? Reason19 { get; set; }
    public decimal? Reason20 { get; set; }
    public decimal? Reason21 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TurnawayStatView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TURNAWAY_STAT_VIEW");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Reason1)
                .HasColumnName("REASON1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason10)
                .HasColumnName("REASON10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason11)
                .HasColumnName("REASON11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason12)
                .HasColumnName("REASON12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason13)
                .HasColumnName("REASON13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason14)
                .HasColumnName("REASON14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason15)
                .HasColumnName("REASON15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason16)
                .HasColumnName("REASON16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason17)
                .HasColumnName("REASON17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason18)
                .HasColumnName("REASON18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason19)
                .HasColumnName("REASON19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason2)
                .HasColumnName("REASON2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason20)
                .HasColumnName("REASON20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason21)
                .HasColumnName("REASON21")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason3)
                .HasColumnName("REASON3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason4)
                .HasColumnName("REASON4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason5)
                .HasColumnName("REASON5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason6)
                .HasColumnName("REASON6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason7)
                .HasColumnName("REASON7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason8)
                .HasColumnName("REASON8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reason9)
                .HasColumnName("REASON9")
                .HasColumnType("NUMBER");
        });
	}
}
