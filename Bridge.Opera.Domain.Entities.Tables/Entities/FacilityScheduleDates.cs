namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FacilityScheduleDates
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime? LastRoomMove { get; set; }
    public DateTime? RescheduleStart { get; set; }
    public string CustomizedYn { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FacilityScheduleDates>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("FSD_PK");

            entity.ToTable("FACILITY_SCHEDULE_DATES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CustomizedYn)
                .HasColumnName("CUSTOMIZED_YN")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.LastRoomMove)
                .HasColumnName("LAST_ROOM_MOVE")
                .HasColumnType("DATE");

            entity.Property(e => e.RescheduleStart)
                .HasColumnName("RESCHEDULE_START")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithOne(p => p.FacilityScheduleDates)
	                .HasForeignKey<FacilityScheduleDates>(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("FSD_RESV_FK");
        });
	}
}
