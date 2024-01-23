namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateUpdateQueueInternal
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string RoomCategory { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public string ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateUpdateQueueInternal>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode, e.RoomCategory, e.BeginDate, e.EndDate, e.ActionType })
                .HasName("GDS_RATE_UPD_INT_PK");

            entity.ToTable("GDS_RATE_UPDATE_QUEUE_INTERNAL");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'I'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("uid ");
        });
	}
}
