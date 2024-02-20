namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortHkTasks
{
    public ResortHkTasks()
    {
        CustomFacilityTaskHeader = new HashSet<CustomFacilityTaskHeader>();
        ResortHkDailyTask = new HashSet<ResortHkDailyTask>();
    }

    public string? TaskCode { get; set; }
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public string? LongDescription { get; set; }
    public decimal? Frequency { get; set; }
    public string? UnitOfFrequency { get; set; }
    public DateTime? TaskAssignDate { get; set; }
    public decimal? Credits { get; set; }
    public decimal? CreditsDeparture { get; set; }
    public decimal? OrderSeq { get; set; }
    public string? DepartureRoomDefaultYn { get; set; }
    public string? Color { get; set; }
    public string? CustomizableYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? LinenChangeYn { get; set; }
    public string? GuestRequestedYn { get; set; }

    public virtual ICollection<CustomFacilityTaskHeader> CustomFacilityTaskHeader { get; set; }
    public virtual ICollection<ResortHkDailyTask> ResortHkDailyTask { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortHkTasks>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_HK_TASKS");

            entity.HasIndex(e => new { e.Resort, e.TaskCode })
                .HasName("HK_TASKS_UK")
                .IsUnique();

            entity.Property(e => e.Color)
                .HasColumnName("COLOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditsDeparture)
                .HasColumnName("CREDITS_DEPARTURE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CustomizableYn)
                .HasColumnName("CUSTOMIZABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.DepartureRoomDefaultYn)
                .HasColumnName("DEPARTURE_ROOM_DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestRequestedYn)
                .HasColumnName("GUEST_REQUESTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinenChangeYn)
                .HasColumnName("LINEN_CHANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OrderSeq)
                .HasColumnName("ORDER_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskAssignDate)
                .HasColumnName("TASK_ASSIGN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaskCode)
                .IsRequired()
                .HasColumnName("TASK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UnitOfFrequency)
                .HasColumnName("UNIT_OF_FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(CustomFacilityTaskHeader)))
				entity.Ignore(e => e.CustomFacilityTaskHeader);

			if (!types.Contains(typeof(ResortHkDailyTask)))
				entity.Ignore(e => e.ResortHkDailyTask);
		});
	}
}
