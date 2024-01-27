namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsRateShopperSch
{
    public string Resort { get; set; }
    public string ShopperCode { get; set; }
    public string ScheduleCode { get; set; }
    public string ScheduleDesc { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public string FrequencyType { get; set; }
    public decimal? Frequency { get; set; }
    public DateTime? LastRunDate { get; set; }
    public DateTime? NextRunDate { get; set; }
    public decimal ArrivalFromdays { get; set; }
    public decimal TotalDays { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual OrmsRateShoppers OrmsRateShoppers { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsRateShopperSch>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ShopperCode, e.ScheduleCode })
                .HasName("ORMS_RTSHOPPERS_SCH_PK");

            entity.ToTable("ORMS_RATE_SHOPPER_SCH");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShopperCode)
                .HasColumnName("SHOPPER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScheduleCode)
                .HasColumnName("SCHEDULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalFromdays)
                .HasColumnName("ARRIVAL_FROMDAYS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Day1)
                .IsRequired()
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day2)
                .IsRequired()
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day3)
                .IsRequired()
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day4)
                .IsRequired()
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day5)
                .IsRequired()
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day6)
                .IsRequired()
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day7)
                .IsRequired()
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FrequencyType)
                .IsRequired()
                .HasColumnName("FREQUENCY_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'H'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastRunDate)
                .HasColumnName("LAST_RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NextRunDate)
                .HasColumnName("NEXT_RUN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScheduleDesc)
                .IsRequired()
                .HasColumnName("SCHEDULE_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TotalDays)
                .HasColumnName("TOTAL_DAYS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("60 ");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsRateShoppers)))
				entity.Ignore(e => e.OrmsRateShoppers);
			else
	            entity.HasOne(d => d.OrmsRateShoppers)
	                .WithMany(p => p.OrmsRateShopperSch)
	                .HasForeignKey(d => new { d.Resort, d.ShopperCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_RTSHOPPER_SCH_FK");
        });
	}
}
