namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomSetup
{
    public RoomSetup()
    {
        EventReservation = new HashSet<EventReservation>();
        ScPkgEventSetup = new HashSet<ScPkgEventSetup>();
    }

    public string? Resort { get; set; }
    public string? Room { get; set; }
    public decimal? SetupcodeId { get; set; }
    public string? SetupCode { get; set; }
    public byte? SetupTime { get; set; }
    public byte? SetdownTime { get; set; }
    public decimal? OccMin { get; set; }
    public decimal? OccMax { get; set; }
    public string? DefaultYn { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual Room R { get; set; }
    public virtual GemTranslation Setupcode { get; set; }
    public virtual ICollection<EventReservation> EventReservation { get; set; }
    public virtual ICollection<ScPkgEventSetup> ScPkgEventSetup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomSetup>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room, e.SetupCode })
                .HasName("SPAS_PK");

            entity.ToTable("ROOM$SETUP");

            entity.HasIndex(e => e.SetupcodeId)
                .HasName("SPAS_SETUPID_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetupCode)
                .HasColumnName("SETUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OccMax)
                .HasColumnName("OCC_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccMin)
                .HasColumnName("OCC_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetdownTime).HasColumnName("SETDOWN_TIME");

            entity.Property(e => e.SetupTime).HasColumnName("SETUP_TIME");

            entity.Property(e => e.SetupcodeId)
                .HasColumnName("SETUPCODE_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemTranslation)))
				entity.Ignore(e => e.Setupcode);
			else
	            entity.HasOne(d => d.Setupcode)
	                .WithMany(p => p.RoomSetup)
	                .HasForeignKey(d => d.SetupcodeId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("SPAS_GT_FK");

			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.RoomSetup)
	                .HasForeignKey(d => new { d.Resort, d.Room })
	                .HasConstraintName("SPAS_ROOM_FK");
        
			if (!types.Contains(typeof(EventReservation)))
				entity.Ignore(e => e.EventReservation);

			if (!types.Contains(typeof(ScPkgEventSetup)))
				entity.Ignore(e => e.ScPkgEventSetup);
		});
	}
}
