namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempNaReports
{
    public decimal? SessionId { get; set; }
    public decimal? ModuleId { get; set; }
    public string ActiveYn { get; set; }
    public string BeforeIaFlag { get; set; }
    public string TraceYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempNaReports>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_NA_REPORTS");

            entity.HasIndex(e => new { e.SessionId, e.ModuleId })
                .HasName("TEMP_NA_IND");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeforeIaFlag)
                .HasColumnName("BEFORE_IA_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TraceYn)
                .HasColumnName("TRACE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
