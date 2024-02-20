namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21Specials
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? StayId { get; set; }
    public string? SpecialRequest { get; set; }
    public string? SpecialRequestDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21Specials>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_SPECIALS");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpecialRequest)
                .HasColumnName("SPECIAL_REQUEST")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpecialRequestDesc)
                .HasColumnName("SPECIAL_REQUEST_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StayId)
                .HasColumnName("STAY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
