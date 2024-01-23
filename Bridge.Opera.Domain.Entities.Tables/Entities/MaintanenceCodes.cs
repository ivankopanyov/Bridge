namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MaintanenceCodes
{
    public MaintanenceCodes()
    {
        RoomMaintenance = new HashSet<RoomMaintenance>();
    }

    public string Resort { get; set; }
    public string MaintenanceCode { get; set; }
    public string Description { get; set; }
    public decimal? DisplaySeq { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual ICollection<RoomMaintenance> RoomMaintenance { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MaintanenceCodes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.MaintenanceCode })
                .HasName("MAINTANENCE_CODES_PK");

            entity.ToTable("MAINTANENCE_CODES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaintenanceCode)
                .HasColumnName("MAINTENANCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(RoomMaintenance)))
				entity.Ignore(e => e.RoomMaintenance);
		});
	}
}
