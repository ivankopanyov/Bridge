namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateAction
{
    public decimal? ActionInstanceId { get; set; }
    public string? RateModuleId { get; set; }
    public string? ActionType { get; set; }
    public string? Machine { get; set; }
    public string? Terminal { get; set; }
    public string? ActionDescription { get; set; }
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public decimal? RateSetId { get; set; }
    public string? ProductId { get; set; }
    public string? SeasonCode { get; set; }
    public string? RateClass { get; set; }
    public string? RateCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? RestrictionId { get; set; }
    public string? YieldCategory { get; set; }
    public DateTime? HurdleDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateAction>(entity =>
        {
            entity.HasKey(e => e.ActionInstanceId)
                .HasName("RA_PK");

            entity.ToTable("RATE_ACTION");

            entity.HasIndex(e => e.InsertDate)
                .HasName("RA_INSDT_IDX");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HurdleDate)
                .HasColumnName("HURDLE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateModuleId)
                .IsRequired()
                .HasColumnName("RATE_MODULE_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionId)
                .HasColumnName("RESTRICTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
