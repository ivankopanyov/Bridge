namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PlayerSnapshotView
{
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? SharedYn { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public decimal? CompBalance { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipNumber { get; set; }
    public string? Vip { get; set; }
    public string? Status { get; set; }
    public string? ResvStatus { get; set; }
    public string? ComputedResvStatus { get; set; }
    public decimal? Balance { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PlayerSnapshotView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PLAYER_SNAPSHOT_VIEW");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompBalance)
                .HasColumnName("COMP_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MembershipNumber)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .IsUnicode(false);

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
