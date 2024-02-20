namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomMaintenance
{
    public decimal? MaintenanceId { get; set; }
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public string? MaintenanceCode { get; set; }
    public string? Remarks { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? ResolvedBy { get; set; }
    public DateTime? ResolvedDate { get; set; }

    public virtual MaintanenceCodes MaintanenceCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomMaintenance>(entity =>
        {
            entity.HasKey(e => e.MaintenanceId)
                .HasName("ROOM_MAINTENANCE_PK");

            entity.ToTable("ROOM_MAINTENANCE");

            entity.HasIndex(e => new { e.Resort, e.MaintenanceCode })
                .HasName("ROOM_MAINTENANCE_FK1_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResolvedDate })
                .HasName("ROOM_MAINTENANCE_IDX");

            entity.Property(e => e.MaintenanceId)
                .HasColumnName("MAINTENANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaintenanceCode)
                .IsRequired()
                .HasColumnName("MAINTENANCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Remarks)
                .IsRequired()
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedBy)
                .HasColumnName("RESOLVED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResolvedDate)
                .HasColumnName("RESOLVED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MaintanenceCodes)))
				entity.Ignore(e => e.MaintanenceCodes);
			else
	            entity.HasOne(d => d.MaintanenceCodes)
	                .WithMany(p => p.RoomMaintenance)
	                .HasForeignKey(d => new { d.Resort, d.MaintenanceCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ROOM_MAINTENANCE_FK1");
        });
	}
}
