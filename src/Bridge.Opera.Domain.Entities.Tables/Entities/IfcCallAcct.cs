namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcCallAcct
{
    public decimal? IfcCtrlId { get; set; }
    public string DialedDigits { get; set; }
    public string TrunkId { get; set; }
    public decimal? TimeId { get; set; }
    public decimal? DayId { get; set; }
    public decimal? StartDuration { get; set; }
    public decimal? EndDuration { get; set; }
    public decimal? NumOfUnits { get; set; }
    public decimal? Tariff { get; set; }
    public string Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcCallAcct>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_CALL_ACCT");

            entity.HasIndex(e => new { e.IfcCtrlId, e.DialedDigits, e.TrunkId })
                .HasName("IFC_CALL_ACCT_IDX");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DayId)
                .HasColumnName("DAY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DialedDigits)
                .HasColumnName("DIALED_DIGITS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDuration)
                .HasColumnName("END_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumOfUnits)
                .HasColumnName("NUM_OF_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDuration)
                .HasColumnName("START_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tariff)
                .HasColumnName("TARIFF")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeId)
                .HasColumnName("TIME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrunkId)
                .HasColumnName("TRUNK_ID")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
