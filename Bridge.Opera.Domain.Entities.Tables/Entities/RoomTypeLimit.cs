namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomTypeLimit
{
    public RoomTypeLimit()
    {
        RoomTypeLimitDetails = new HashSet<RoomTypeLimitDetails>();
    }

    public decimal LimitId { get; set; }
    public string Description { get; set; }
    public string Resort { get; set; }
    public string RoomCategory { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<RoomTypeLimitDetails> RoomTypeLimitDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomTypeLimit>(entity =>
        {
            entity.HasKey(e => e.LimitId)
                .HasName("RTL_PK");

            entity.ToTable("ROOM_TYPE_LIMIT");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory })
                .HasName("RTL_RES_ROOM_CAT_IDX");

            entity.Property(e => e.LimitId)
                .HasColumnName("LIMIT_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
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
        
			if (!types.Contains(typeof(RoomTypeLimitDetails)))
				entity.Ignore(e => e.RoomTypeLimitDetails);
		});
	}
}
