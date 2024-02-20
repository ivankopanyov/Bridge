namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ComponentRoomType
{
    public string? Resort { get; set; }
    public string? CombinationRoomCategory { get; set; }
    public string? ComponentRoomCategory { get; set; }
    public decimal? Quantity { get; set; }
    public string? SuiteCategory { get; set; }
    public string? Label { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ComponentRoomType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COMPONENT_ROOM_TYPE");

            entity.Property(e => e.CombinationRoomCategory)
                .IsRequired()
                .HasColumnName("COMBINATION_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComponentRoomCategory)
                .IsRequired()
                .HasColumnName("COMPONENT_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SuiteCategory)
                .IsRequired()
                .HasColumnName("SUITE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
