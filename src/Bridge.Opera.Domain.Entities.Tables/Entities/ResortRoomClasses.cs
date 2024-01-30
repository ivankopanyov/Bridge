namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortRoomClasses
{
    public ResortRoomClasses()
    {
        RateTranslation = new HashSet<RateTranslation>();
        ResortRoomCategory = new HashSet<ResortRoomCategory>();
        Room = new HashSet<Room>();
    }

    public string? Resort { get; set; }
    public string? RoomClass { get; set; }
    public decimal? SellSequence { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? Description { get; set; }
    public string? CanDeleteYn { get; set; }

    public virtual Resort ResortNavigation { get; set; }
    public virtual ICollection<RateTranslation> RateTranslation { get; set; }
    public virtual ICollection<ResortRoomCategory> ResortRoomCategory { get; set; }
    public virtual ICollection<Room> Room { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortRoomClasses>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RoomClass })
                .HasName("RESORT_ROOM_CLASSES_PK");

            entity.ToTable("RESORT_ROOM_CLASSES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER(20)");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ResortRoomClasses)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RRC_RESORT_FK");
        
			if (!types.Contains(typeof(RateTranslation)))
				entity.Ignore(e => e.RateTranslation);

			if (!types.Contains(typeof(ResortRoomCategory)))
				entity.Ignore(e => e.ResortRoomCategory);

			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.Room);
		});
	}
}
