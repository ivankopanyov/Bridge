namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BusinessProfileBlock
{
    public decimal ProfileId { get; set; }
    public decimal DayOrder { get; set; }
    public decimal RoomCategory { get; set; }
    public decimal? ForecastedToSell { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual BusinessProfile Profile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BusinessProfileBlock>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.DayOrder, e.RoomCategory })
                .HasName("BPB_PK");

            entity.ToTable("BUSINESS$PROFILE_BLOCK");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayOrder)
                .HasColumnName("DAY_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastedToSell)
                .HasColumnName("FORECASTED_TO_SELL")
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

			if (!types.Contains(typeof(BusinessProfile)))
				entity.Ignore(e => e.Profile);
			else
	            entity.HasOne(d => d.Profile)
	                .WithMany(p => p.BusinessProfileBlock)
	                .HasForeignKey(d => d.ProfileId)
	                .HasConstraintName("BPB_BP_FK");
        });
	}
}
