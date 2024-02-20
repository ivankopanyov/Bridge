namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FpReservationMessageGtt
{
    public string? Resort { get; set; }
    public string? ActionType { get; set; }
    public decimal? ActionInstanceId { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? OldBeginDate { get; set; }
    public DateTime? OldEndDate { get; set; }
    public DateTime? NewBeginDate { get; set; }
    public DateTime? NewEndDate { get; set; }
    public string? EventParameters { get; set; }
    public DateTime? InsertTs { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FpReservationMessageGtt>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FP_RESERVATION_MESSAGE_GTT");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EventParameters)
                .HasColumnName("EVENT_PARAMETERS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertTs)
                .HasColumnName("INSERT_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.NewBeginDate)
                .HasColumnName("NEW_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NewEndDate)
                .HasColumnName("NEW_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OldBeginDate)
                .HasColumnName("OLD_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OldEndDate)
                .HasColumnName("OLD_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
