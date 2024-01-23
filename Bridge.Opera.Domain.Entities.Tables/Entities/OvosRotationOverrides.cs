namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosRotationOverrides
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime BusinessDate { get; set; }
    public string RotationRoom { get; set; }
    public string OverrideRoom { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string ActionType { get; set; }
    public decimal? RotationRoomPoints { get; set; }
    public decimal? OverrideRoomPoints { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? OverrideId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosRotationOverrides>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OVOS_ROTATION_OVERRIDES");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("ORO_RES_RESV_IDX");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.Code })
                .HasName("ORO_RES_BD_CODE_IDX");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.RotationRoom })
                .HasName("ORO_RES_BD_ROTROOM_IDX");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideId)
                .HasColumnName("OVERRIDE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideRoom)
                .IsRequired()
                .HasColumnName("OVERRIDE_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OverrideRoomPoints)
                .HasColumnName("OVERRIDE_ROOM_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RotationRoom)
                .IsRequired()
                .HasColumnName("ROTATION_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RotationRoomPoints)
                .HasColumnName("ROTATION_ROOM_POINTS")
                .HasColumnType("NUMBER");
        });
	}
}
