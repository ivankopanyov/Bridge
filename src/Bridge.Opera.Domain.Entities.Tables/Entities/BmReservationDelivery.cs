namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmReservationDelivery
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public string? ResInsertSource { get; set; }
    public string? DeliveryMethod { get; set; }
    public decimal? Osn { get; set; }
    public string? InterfaceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmReservationDelivery>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BM_RESERVATION_DELIVERY");

            entity.HasIndex(e => e.ResvNameId)
                .HasName("BM_RESERVATION_DELIVERY_IND2");

            entity.HasIndex(e => new { e.DeliveryDate, e.Resort, e.DeliveryMethod })
                .HasName("BM_RESERVATION_DELIVERY_IND1");

            entity.Property(e => e.DeliveryDate)
                .HasColumnName("DELIVERY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DeliveryMethod)
                .IsRequired()
                .HasColumnName("DELIVERY_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Osn)
                .HasColumnName("OSN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
