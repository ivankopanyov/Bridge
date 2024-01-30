namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BookerTravelerLink
{
    public decimal? BookerUserId { get; set; }
    public decimal? TravelerNameId { get; set; }
    public string? PermissionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookerTravelerLink>(entity =>
        {
            entity.HasKey(e => new { e.BookerUserId, e.TravelerNameId })
                .HasName("BOOKER_TRAVELER_LINK_PK");

            entity.ToTable("BOOKER_TRAVELER_LINK");

            entity.Property(e => e.BookerUserId)
                .HasColumnName("BOOKER_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelerNameId)
                .HasColumnName("TRAVELER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermissionType)
                .HasColumnName("PERMISSION_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
