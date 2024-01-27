namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempStayDates
{
    public DateTime StayDate { get; set; }
    public string DayType { get; set; }
    public decimal? Multiplier { get; set; }
    public decimal? Adder { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempStayDates>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_STAY_DATES");

            entity.HasIndex(e => new { e.StayDate, e.DayType })
                .HasName("TEMP_STAY_DATES_IDX_01");

            entity.Property(e => e.Adder)
                .HasColumnName("ADDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayType)
                .HasColumnName("DAY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Multiplier)
                .HasColumnName("MULTIPLIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");
        });
	}
}
