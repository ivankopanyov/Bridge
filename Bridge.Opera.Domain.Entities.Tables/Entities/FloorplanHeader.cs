namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FloorplanHeader
{
    public string Resort { get; set; }
    public decimal FloorId { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FloorplanHeader>(entity =>
        {
            entity.HasKey(e => e.FloorId)
                .HasName("FPHDR_PK");

            entity.ToTable("FLOORPLAN_HEADER");

            entity.HasIndex(e => e.Resort)
                .HasName("FPHDR_RESORT_IDX");

            entity.Property(e => e.FloorId)
                .HasColumnName("FLOOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
