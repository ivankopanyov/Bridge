namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationDeliveryHistory
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal DeliveryId { get; set; }
    public string DeliveryMethod { get; set; }
    public string InterfaceId { get; set; }
    public string Status { get; set; }
    public string ErrorDesc { get; set; }
    public decimal? RetryCount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeliveryDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationDeliveryHistory>(entity =>
        {
            entity.HasKey(e => new { e.ResvNameId, e.Resort, e.DeliveryId })
                .HasName("RESERVATION_DELI_HIST_PK");

            entity.ToTable("RESERVATION_DELIVERY_HISTORY");

            entity.HasIndex(e => new { e.DeliveryMethod, e.DeliveryDate })
                .HasName("RESERVATION_DELI_HIST_IND2");

            entity.HasIndex(e => new { e.InterfaceId, e.DeliveryDate })
                .HasName("RESERVATION_DELI_HIST_IND1");

            entity.HasIndex(e => new { e.Status, e.DeliveryDate, e.InterfaceId })
                .HasName("RESERVATION_DELI_HIST_IND3");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryId)
                .HasColumnName("DELIVERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeliveryDate)
                .HasColumnName("DELIVERY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DeliveryMethod)
                .IsRequired()
                .HasColumnName("DELIVERY_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
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
