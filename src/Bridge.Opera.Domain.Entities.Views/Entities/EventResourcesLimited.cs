namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventResourcesLimited
{
    public string? ResourceType { get; set; }
    public decimal? ResourceGroupId { get; set; }
    public decimal? ResourceId { get; set; }
    public string? ResourceName { get; set; }
    public string? Code { get; set; }
    public string? Resort { get; set; }
    public decimal? EventId { get; set; }
    public decimal? BookId { get; set; }
    public decimal? ResourceSegment { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? PkgId { get; set; }
    public decimal? ClassId { get; set; }
    public string? OrderByChar { get; set; }
    public string? OrderByResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventResourcesLimited>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_RESOURCES_LIMITED");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClassId)
                .HasColumnName("CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderByChar)
                .HasColumnName("ORDER_BY_CHAR")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.OrderByResort)
                .HasColumnName("ORDER_BY_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResourceGroupId)
                .HasColumnName("RESOURCE_GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceId)
                .HasColumnName("RESOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceName)
                .HasColumnName("RESOURCE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResourceSegment)
                .HasColumnName("RESOURCE_SEGMENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceType)
                .HasColumnName("RESOURCE_TYPE")
                .HasMaxLength(13)
                .IsUnicode(false);
        });
	}
}
