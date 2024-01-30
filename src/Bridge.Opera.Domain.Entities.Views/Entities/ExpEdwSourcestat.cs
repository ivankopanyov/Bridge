namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEdwSourcestat
{
    public decimal? ExportId { get; set; }
    public string? EdwType { get; set; }
    public string? PmsVersion { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string? SourceCode { get; set; }
    public string? SourceDescription { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalRoomAdj { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEdwSourcestat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EDW_SOURCESTAT");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EdwType)
                .HasColumnName("EDW_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsVersion)
                .HasColumnName("PMS_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceDescription)
                .HasColumnName("SOURCE_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotalRoomAdj)
                .HasColumnName("TOTAL_ROOM_ADJ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
