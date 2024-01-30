namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempDailyRatesRecommd
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RoomType { get; set; }
    public DateTime? RateDate { get; set; }
    public decimal? OneAdultRate { get; set; }
    public decimal? TwoAdultsRate { get; set; }
    public decimal? ExtraAdultRate { get; set; }
    public decimal? ExtraChildRate { get; set; }
    public decimal? ChildCharge1 { get; set; }
    public decimal? ChildCharge2 { get; set; }
    public decimal? ChildCharge3 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempDailyRatesRecommd>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_DAILY_RATES_RECOMMD");

            entity.Property(e => e.ChildCharge1)
                .HasColumnName("CHILD_CHARGE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge2)
                .HasColumnName("CHILD_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge3)
                .HasColumnName("CHILD_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtraAdultRate)
                .HasColumnName("EXTRA_ADULT_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtraChildRate)
                .HasColumnName("EXTRA_CHILD_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OneAdultRate)
                .HasColumnName("ONE_ADULT_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateDate)
                .HasColumnName("RATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TwoAdultsRate)
                .HasColumnName("TWO_ADULTS_RATE")
                .HasColumnType("NUMBER");
        });
	}
}
