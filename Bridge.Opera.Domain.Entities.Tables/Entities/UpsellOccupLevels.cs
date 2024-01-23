namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UpsellOccupLevels
{
    public string Resort { get; set; }
    public decimal LevelId { get; set; }
    public decimal FromOccup { get; set; }
    public decimal ToOccup { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpsellOccupLevels>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("UPSELL_OCCUP_LEVELS");

            entity.HasIndex(e => new { e.Resort, e.LevelId, e.FromOccup, e.ToOccup })
                .HasName("UPSELL_OCCUP_LEVELS_IDX1")
                .IsUnique();

            entity.Property(e => e.FromOccup)
                .HasColumnName("FROM_OCCUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LevelId)
                .HasColumnName("LEVEL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToOccup)
                .HasColumnName("TO_OCCUP")
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
