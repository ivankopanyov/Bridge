namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ClockInClockOut
{
    public string Resort { get; set; }
    public decimal NameId { get; set; }
    public DateTime ClockedIn { get; set; }
    public DateTime? ClockedOut { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ClockInClockOut>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.NameId, e.ClockedIn })
                .HasName("QMS_CICO_PK");

            entity.ToTable("CLOCK_IN_CLOCK_OUT");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClockedIn)
                .HasColumnName("CLOCKED_IN")
                .HasColumnType("DATE");

            entity.Property(e => e.ClockedOut)
                .HasColumnName("CLOCKED_OUT")
                .HasColumnType("DATE");
        });
	}
}
