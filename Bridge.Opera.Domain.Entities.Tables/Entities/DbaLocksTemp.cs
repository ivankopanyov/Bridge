namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DbaLocksTemp
{
    public decimal? SessionId { get; set; }
    public string LockType { get; set; }
    public string ModeHeld { get; set; }
    public string ModeRequested { get; set; }
    public string LockId1 { get; set; }
    public string LockId2 { get; set; }
    public decimal? LastConvert { get; set; }
    public string BlockingOthers { get; set; }
    public decimal? InstanceId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DbaLocksTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DBA_LOCKS_TEMP");

            entity.Property(e => e.BlockingOthers)
                .HasColumnName("BLOCKING_OTHERS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InstanceId)
                .HasColumnName("INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastConvert)
                .HasColumnName("LAST_CONVERT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LockId1)
                .HasColumnName("LOCK_ID1")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LockId2)
                .HasColumnName("LOCK_ID2")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LockType)
                .HasColumnName("LOCK_TYPE")
                .HasMaxLength(26)
                .IsUnicode(false);

            entity.Property(e => e.ModeHeld)
                .HasColumnName("MODE_HELD")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ModeRequested)
                .HasColumnName("MODE_REQUESTED")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER");
        });
	}
}
