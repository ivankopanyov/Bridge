namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CustomFacilityCodesSchedule
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime ReservationDate { get; set; }
    public string Room { get; set; }
    public string RoomCategory { get; set; }
    public string FacilityTask { get; set; }
    public string FacilityCode { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual CustomFacilityTaskSchedule CustomFacilityTaskSchedule { get; set; }
    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CustomFacilityCodesSchedule>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.ReservationDate, e.FacilityTask, e.FacilityCode })
                .HasName("CUS_FAC_PK");

            entity.ToTable("CUSTOM_FACILITY_CODES_SCHEDULE");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.RoomCategory, e.FacilityTask })
                .HasName("CUS_FAC_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FacilityTask)
                .HasColumnName("FACILITY_TASK")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FacilityCode)
                .HasColumnName("FACILITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.CustomFacilityCodesSchedule)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CUS_FAC_RESV_FK");

			if (!types.Contains(typeof(CustomFacilityTaskSchedule)))
				entity.Ignore(e => e.CustomFacilityTaskSchedule);
			else
	            entity.HasOne(d => d.CustomFacilityTaskSchedule)
	                .WithMany(p => p.CustomFacilityCodesSchedule)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId, d.ReservationDate, d.FacilityTask })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CUS_FAC_TS_FK");
        });
	}
}
