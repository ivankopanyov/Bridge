namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomCategoryFacilityTasks
{
    public string Resort { get; set; }
    public string RoomCategory { get; set; }
    public string FacilityTask { get; set; }
    public decimal? Credits { get; set; }
    public string Frequency { get; set; }
    public decimal? Priority { get; set; }
    public decimal? FrequencyDays { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string SpecialRequests { get; set; }
    public string VipStatuses { get; set; }
    public decimal? FacilityTaskSeq { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public string RateCodes { get; set; }
    public string MarketCodes { get; set; }
    public decimal? CycleStartDay { get; set; }
    public string CustomizePromptYn { get; set; }
    public string CustomizePromptText { get; set; }

    public virtual ResortRoomCategory R { get; set; }
    public virtual ResortHkTasks ResortHkTasks { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomCategoryFacilityTasks>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ROOM_CATEGORY_FACILITY_TASKS");

            entity.HasIndex(e => e.FacilityTaskSeq)
                .HasName("ROOM_CAT_FACILITY_TASKS_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.FacilityTask })
                .HasName("RCAT_FT_RHKT_FKI");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory, e.FacilityTask })
                .HasName("RCAT_FT_IDX1");

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CustomizePromptText)
                .HasColumnName("CUSTOMIZE_PROMPT_TEXT")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.CustomizePromptYn)
                .HasColumnName("CUSTOMIZE_PROMPT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CycleStartDay)
                .HasColumnName("CYCLE_START_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FacilityTask)
                .IsRequired()
                .HasColumnName("FACILITY_TASK")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FacilityTaskSeq)
                .IsRequired()
                .HasColumnName("FACILITY_TASK_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FrequencyDays)
                .HasColumnName("FREQUENCY_DAYS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCodes)
                .HasColumnName("MARKET_CODES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCodes)
                .HasColumnName("RATE_CODES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SpecialRequests)
                .HasColumnName("SPECIAL_REQUESTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipStatuses)
                .HasColumnName("VIP_STATUSES")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(ResortHkTasks)))
				entity.Ignore(e => e.ResortHkTasks);
			else
	            entity.HasOne(d => d.ResortHkTasks)
	                .WithMany()
	                .HasPrincipalKey(p => new { p.Resort, p.TaskCode })
	                .HasForeignKey(d => new { d.Resort, d.FacilityTask })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RCAT_FT_RHKT_FK");

			if (!types.Contains(typeof(ResortRoomCategory)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.RoomCategory })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RCAT_FT_RRC_FK");
        });
	}
}
