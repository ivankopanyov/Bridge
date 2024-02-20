namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PmsForecastCorrelation
{
    public string? CorrId { get; set; }
    public Guid MsgId { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsForecastCorrelation>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PMS_FORECAST_CORRELATION");

            entity.HasIndex(e => new { e.CorrId, e.MsgId })
                .HasName("PMS_FC_CORR_IDX");

            entity.Property(e => e.CorrId)
                .IsRequired()
                .HasColumnName("CORR_ID")
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MsgId).HasColumnName("MSG_ID");
        });
	}
}
