namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomStatusReason
{
    public string? Description { get; set; }
    public string? ReasonCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomStatusReason>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_STATUS_REASON");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReasonCode)
                .IsRequired()
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
