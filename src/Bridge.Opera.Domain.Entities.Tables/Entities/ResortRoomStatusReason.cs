namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortRoomStatusReason
{
    public ResortRoomStatusReason()
    {
        RoomRepairs = new HashSet<RoomRepairs>();
    }

    public string? ReasonCode { get; set; }
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual ICollection<RoomRepairs> RoomRepairs { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortRoomStatusReason>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_ROOM_STATUS_REASON");

            entity.HasIndex(e => new { e.ReasonCode, e.Resort })
                .HasName("ROOM_STATUS_REASON_UK")
                .IsUnique();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false)
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

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReasonCode)
                .IsRequired()
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(RoomRepairs)))
				entity.Ignore(e => e.RoomRepairs);
		});
	}
}
