namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PmsRategridviewLos
{
    public string RoomCategory { get; set; }
    public string Label { get; set; }
    public string YieldCategory { get; set; }
    public DateTime HurdleDate { get; set; }
    public decimal? Los1Amt { get; set; }
    public decimal? Los2Amt { get; set; }
    public decimal? Los3Amt { get; set; }
    public decimal? Los4Amt { get; set; }
    public decimal? Los5Amt { get; set; }
    public decimal? Los6Amt { get; set; }
    public decimal? Los7Amt { get; set; }
    public decimal? Los8Amt { get; set; }
    public decimal? Los9Amt { get; set; }
    public decimal? Los10Amt { get; set; }
    public decimal? Los11Amt { get; set; }
    public decimal? Los12Amt { get; set; }
    public decimal? Los13Amt { get; set; }
    public decimal? Los14Amt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsRategridviewLos>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PMS_RATEGRIDVIEW_LOS");

            entity.Property(e => e.HurdleDate)
                .HasColumnName("HURDLE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Los10Amt)
                .HasColumnName("LOS10_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los11Amt)
                .HasColumnName("LOS11_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los12Amt)
                .HasColumnName("LOS12_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los13Amt)
                .HasColumnName("LOS13_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los14Amt)
                .HasColumnName("LOS14_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los1Amt)
                .HasColumnName("LOS1_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los2Amt)
                .HasColumnName("LOS2_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los3Amt)
                .HasColumnName("LOS3_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los4Amt)
                .HasColumnName("LOS4_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los5Amt)
                .HasColumnName("LOS5_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los6Amt)
                .HasColumnName("LOS6_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los7Amt)
                .HasColumnName("LOS7_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los8Amt)
                .HasColumnName("LOS8_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los9Amt)
                .HasColumnName("LOS9_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
