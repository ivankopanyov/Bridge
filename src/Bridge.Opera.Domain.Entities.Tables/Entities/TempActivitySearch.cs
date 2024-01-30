namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempActivitySearch
{
    public string? LinkType { get; set; }
    public decimal? LinkId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempActivitySearch>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_ACTIVITY_SEARCH");

            entity.HasIndex(e => new { e.LinkType, e.LinkId })
                .HasName("TEMP_ACTIVITY_SEARCH_UIDX")
                .IsUnique();

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkType)
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
