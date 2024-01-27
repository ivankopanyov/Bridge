namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomTypeLimitDetails
{
    public decimal LimitId { get; set; }
    public decimal ItemId { get; set; }
    public decimal Quantity { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual RoomTypeLimit Limit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomTypeLimitDetails>(entity =>
        {
            entity.HasKey(e => new { e.LimitId, e.ItemId })
                .HasName("RTLD_PK");

            entity.ToTable("ROOM_TYPE_LIMIT_DETAILS");

            entity.Property(e => e.LimitId)
                .HasColumnName("LIMIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RoomTypeLimit)))
				entity.Ignore(e => e.Limit);
			else
	            entity.HasOne(d => d.Limit)
	                .WithMany(p => p.RoomTypeLimitDetails)
	                .HasForeignKey(d => d.LimitId)
	                .HasConstraintName("RTL_RTLD_FK");
        });
	}
}
