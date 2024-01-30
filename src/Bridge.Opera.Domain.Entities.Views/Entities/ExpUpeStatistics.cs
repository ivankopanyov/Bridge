namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeStatistics
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string? RoomCategory { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? StatGroup { get; set; }
    public string? StatCode { get; set; }
    public decimal? StatValue { get; set; }
    public string? StatCategoryCode { get; set; }
    public string? RoomCategoryLabel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_STATISTICS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatCategoryCode)
                .HasColumnName("STAT_CATEGORY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatCode)
                .HasColumnName("STAT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatGroup)
                .HasColumnName("STAT_GROUP")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatValue)
                .HasColumnName("STAT_VALUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
