namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsInventoryUpdate
{
    public decimal RestatusId { get; set; }
    public string GdsHost { get; set; }
    public string Resort { get; set; }
    public string GdsRoomCategory { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string RestatusType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsInventoryUpdate>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_INVENTORY_UPDATE");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRoomCategory)
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestatusId)
                .HasColumnName("RESTATUS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RestatusType)
                .IsRequired()
                .HasColumnName("RESTATUS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
