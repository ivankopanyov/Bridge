namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LockHolders
{
    public decimal? WaitingSession { get; set; }
    public decimal? HoldingSession { get; set; }
    public string? LockType { get; set; }
    public string? ModeHeld { get; set; }
    public string? ModeRequested { get; set; }
    public string? LockId1 { get; set; }
    public string? LockId2 { get; set; }
    public decimal? InstanceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LockHolders>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("LOCK_HOLDERS");

            entity.Property(e => e.HoldingSession)
                .HasColumnName("HOLDING_SESSION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstanceId)
                .HasColumnName("INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LockId1)
                .HasColumnName("LOCK_ID1")
                .HasMaxLength(22)
                .IsUnicode(false);

            entity.Property(e => e.LockId2)
                .HasColumnName("LOCK_ID2")
                .HasMaxLength(22)
                .IsUnicode(false);

            entity.Property(e => e.LockType)
                .HasColumnName("LOCK_TYPE")
                .HasMaxLength(26)
                .IsUnicode(false);

            entity.Property(e => e.ModeHeld)
                .HasColumnName("MODE_HELD")
                .HasMaxLength(14)
                .IsUnicode(false);

            entity.Property(e => e.ModeRequested)
                .HasColumnName("MODE_REQUESTED")
                .HasMaxLength(14)
                .IsUnicode(false);

            entity.Property(e => e.WaitingSession)
                .HasColumnName("WAITING_SESSION")
                .HasColumnType("NUMBER");
        });
	}
}
