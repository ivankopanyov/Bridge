namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsErrorLog
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public DateTime LastUpdateTime { get; set; }
    public decimal LastUpdateUser { get; set; }
    public string RoomCategory { get; set; }
    public string ErrorMessage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsErrorLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OWS_ERROR_LOG");

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdateTime)
                .HasColumnName("LAST_UPDATE_TIME")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.LastUpdateUser)
                .HasColumnName("LAST_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
