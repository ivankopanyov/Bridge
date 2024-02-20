namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateDiscountLevels
{
    public string? Resort { get; set; }
    public decimal? DiscountLevel { get; set; }
    public string? Description { get; set; }
    public decimal? Discount { get; set; }
    public decimal? RoomProduction { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? RevenueProduction { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateDiscountLevels>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RATE_DISCOUNT_LEVELS");

            entity.HasIndex(e => new { e.DiscountLevel, e.Resort })
                .HasName("RDL_UK")
                .IsUnique();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountLevel)
                .HasColumnName("DISCOUNT_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueProduction)
                .HasColumnName("REVENUE_PRODUCTION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomProduction)
                .HasColumnName("ROOM_PRODUCTION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
