namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GrntAvlView
{
    public string? RoomCategory { get; set; }
    public string? Label { get; set; }
    public string? Total { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GrntAvlView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GRNT_AVL_VIEW");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Total)
                .HasColumnName("TOTAL")
                .IsUnicode(false);
        });
	}
}
