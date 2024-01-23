namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationVirtualJrnlGtt
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal Pool { get; set; }
    public string Virtual { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public decimal? SessionId { get; set; }
    public string Action { get; set; }
    public DateTime ActionTs { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationVirtualJrnlGtt>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESERVATION_VIRTUAL#_JRNL_GTT");

            entity.Property(e => e.Action)
                .IsRequired()
                .HasColumnName("ACTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ActionTs)
                .HasColumnName("ACTION_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Pool)
                .HasColumnName("POOL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Username)
                .HasColumnName("USERNAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Virtual)
                .IsRequired()
                .HasColumnName("VIRTUAL#")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
