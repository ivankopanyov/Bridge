namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateStrategyExtRef
{
    public decimal? RateStrategyId { get; set; }
    public string? InterfaceId { get; set; }
    public string? ExtRateStrategyId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? Udfc01 { get; set; }
    public string? ExchangeYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateStrategyExtRef>(entity =>
        {
            entity.HasKey(e => new { e.RateStrategyId, e.InterfaceId })
                .HasName("RATESTRAT_EXTREF_PK");

            entity.ToTable("RATE_STRATEGY_EXT_REF");

            entity.Property(e => e.RateStrategyId)
                .HasColumnName("RATE_STRATEGY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeYn)
                .HasColumnName("EXCHANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExtRateStrategyId)
                .HasColumnName("EXT_RATE_STRATEGY_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
