namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsPriceRoomDelta
{
    public string Resort { get; set; }
    public decimal HeaderId { get; set; }
    public decimal PricesliceId { get; set; }
    public string RoomCategory { get; set; }
    public decimal Delta { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual OrmsPriceDetails OrmsPriceDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsPriceRoomDelta>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.HeaderId, e.PricesliceId, e.RoomCategory })
                .HasName("ORMS_PRICE_ROOM_DELTA_PK");

            entity.ToTable("ORMS_PRICE_ROOM_DELTA");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HeaderId)
                .HasColumnName("HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PricesliceId)
                .HasColumnName("PRICESLICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Delta)
                .HasColumnName("DELTA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OrmsPriceDetails)))
				entity.Ignore(e => e.OrmsPriceDetails);
			else
	            entity.HasOne(d => d.OrmsPriceDetails)
	                .WithMany(p => p.OrmsPriceRoomDelta)
	                .HasForeignKey(d => new { d.Resort, d.HeaderId, d.PricesliceId })
	                .HasConstraintName("ORMS_PRICE_ROOM_DELTA_FK");
        });
	}
}
