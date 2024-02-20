namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsToSell
{
    public decimal? LimitId { get; set; }
    public string? GdsHost { get; set; }
    public string? Resort { get; set; }
    public string? GdsRoomCategory { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public decimal? NoRooms { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsToSell>(entity =>
        {
            entity.HasKey(e => e.LimitId)
                .HasName("GDS_TO_SELL_PK");

            entity.ToTable("GDS_TO_SELL");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.BeginDate, e.GdsRoomCategory })
                .HasName("GDS_TO_SELL");

            entity.Property(e => e.LimitId)
                .HasColumnName("LIMIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Day1)
                .IsRequired()
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .IsRequired()
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .IsRequired()
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .IsRequired()
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .IsRequired()
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .IsRequired()
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .IsRequired()
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRoomCategory)
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
