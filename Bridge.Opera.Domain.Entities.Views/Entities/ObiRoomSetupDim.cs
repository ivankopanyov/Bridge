namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRoomSetupDim
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string Resort { get; set; }
    public string Room { get; set; }
    public decimal? SetupcodeId { get; set; }
    public string SetupCode { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public decimal? OccMin { get; set; }
    public decimal? OccMax { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRoomSetupDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ROOM_SETUP_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OccMax)
                .HasColumnName("OCC_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccMin)
                .HasColumnName("OCC_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .IsUnicode(false);

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupCode)
                .HasColumnName("SETUP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupcodeId)
                .HasColumnName("SETUPCODE_ID")
                .HasColumnType("NUMBER");
        });
	}
}
