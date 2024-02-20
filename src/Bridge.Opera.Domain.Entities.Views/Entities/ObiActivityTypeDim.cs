namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiActivityTypeDim
{
    public string? ActivityType { get; set; }
    public string? Description { get; set; }
    public string? ClassList { get; set; }
    public string? Resort { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiActivityTypeDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ACTIVITY_TYPE_DIM");

            entity.Property(e => e.ActivityType)
                .IsRequired()
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClassList)
                .HasColumnName("CLASS_LIST")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
