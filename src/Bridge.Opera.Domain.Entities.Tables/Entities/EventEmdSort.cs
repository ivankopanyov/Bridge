namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventEmdSort
{
    public decimal? MitId { get; set; }
    public decimal? MencId { get; set; }
    public decimal? EventMenuId { get; set; }
    public string? Name { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? SalesPrice { get; set; }
    public decimal? Course { get; set; }
    public decimal? CourseOrder { get; set; }
    public string? IncludedYn { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventEmdSort>(entity =>
        {
            entity.HasKey(e => e.MitId)
                .HasName("EMDS_PK");

            entity.ToTable("EVENT$EMD_SORT");

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Course)
                .HasColumnName("COURSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CourseOrder)
                .HasColumnName("COURSE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventMenuId)
                .HasColumnName("EVENT_MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IncludedYn)
                .HasColumnName("INCLUDED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MencId)
                .HasColumnName("MENC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SalesPrice)
                .HasColumnName("SALES_PRICE")
                .HasColumnType("NUMBER");
        });
	}
}
