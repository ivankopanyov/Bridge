namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosRoomStatusReasons
{
    public decimal? Id { get; set; }
    public string ReasonCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosRoomStatusReasons>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OVOS_ROOM_STATUS_REASONS");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
