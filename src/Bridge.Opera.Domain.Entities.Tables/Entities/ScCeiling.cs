namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScCeiling
{
    public decimal? CeilingId { get; set; }
    public string? Resort { get; set; }
    public DateTime? CeilingDate { get; set; }
    public string? PmsRoomtype { get; set; }
    public short? Quantity { get; set; }
    public string? RestrictedYn { get; set; }
    public string? ProtectedYn { get; set; }
    public DateTime? CutoffDate { get; set; }
    public decimal? Booked { get; set; }
    public decimal? Overbooked { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScCeiling>(entity =>
        {
            entity.HasKey(e => e.CeilingId)
                .HasName("CEIL_PK");

            entity.ToTable("SC_CEILING");

            entity.HasIndex(e => new { e.Resort, e.PmsRoomtype })
                .HasName("CEIL_RESORT_RCAT");

            entity.HasIndex(e => new { e.Resort, e.CeilingDate, e.PmsRoomtype })
                .HasName("CEIL_UK")
                .IsUnique();

            entity.Property(e => e.CeilingId)
                .HasColumnName("CEILING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Booked)
                .HasColumnName("BOOKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CeilingDate)
                .HasColumnName("CEILING_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CutoffDate)
                .HasColumnName("CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Overbooked)
                .HasColumnName("OVERBOOKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsRoomtype)
                .HasColumnName("PMS_ROOMTYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProtectedYn)
                .HasColumnName("PROTECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RestrictedYn)
                .HasColumnName("RESTRICTED_YN")
                .HasMaxLength(1)
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
