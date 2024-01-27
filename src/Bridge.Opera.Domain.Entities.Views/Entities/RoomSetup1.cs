namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomSetup1
{
    public string Resort { get; set; }
    public string Room { get; set; }
    public decimal SetupcodeId { get; set; }
    public string SetupCode { get; set; }
    public byte? SetupTime { get; set; }
    public byte? SetdownTime { get; set; }
    public decimal? OccMin { get; set; }
    public decimal? OccMax { get; set; }
    public string DefaultYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string WebBookingYn { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomSetup1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_SETUP");

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OccMax)
                .HasColumnName("OCC_MAX")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OccMin)
                .HasColumnName("OCC_MIN")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetupCode)
                .IsRequired()
                .HasColumnName("SETUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetupcodeId)
                .HasColumnName("SETUPCODE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
