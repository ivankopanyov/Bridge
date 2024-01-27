namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HkTasks
{
    public string TaskCode { get; set; }
    public string Description { get; set; }
    public string LongDescription { get; set; }
    public DateTime? TaskAssignDate { get; set; }
    public decimal? Credits { get; set; }
    public decimal? CreditsDeparture { get; set; }
    public decimal? OrderSeq { get; set; }
    public string Color { get; set; }
    public string Frequency { get; set; }
    public string UnitOfFrequency { get; set; }
    public string DepartureRoomDefaultYn { get; set; }
    public string CustomizableYn { get; set; }
    public string LinenChangeYn { get; set; }
    public string GuestRequestedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkTasks>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HK_TASKS");

            entity.Property(e => e.Color)
                .HasColumnName("COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditsDeparture)
                .HasColumnName("CREDITS_DEPARTURE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CustomizableYn)
                .HasColumnName("CUSTOMIZABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepartureRoomDefaultYn)
                .HasColumnName("DEPARTURE_ROOM_DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasColumnType("CHAR(2000)");

            entity.Property(e => e.GuestRequestedYn)
                .HasColumnName("GUEST_REQUESTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskAssignDate)
                .HasColumnName("TASK_ASSIGN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaskCode)
                .IsRequired()
                .HasColumnName("TASK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UnitOfFrequency)
                .HasColumnName("UNIT_OF_FREQUENCY")
                .HasColumnType("CHAR(2000)");
        });
	}
}
