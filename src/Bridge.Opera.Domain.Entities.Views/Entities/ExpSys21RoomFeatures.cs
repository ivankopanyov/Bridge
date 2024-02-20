namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21RoomFeatures
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string? Room { get; set; }
    public string? FeatureCode { get; set; }
    public string? FeatureDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21RoomFeatures>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_ROOM_FEATURES");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FeatureCode)
                .HasColumnName("FEATURE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FeatureDesc)
                .HasColumnName("FEATURE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
