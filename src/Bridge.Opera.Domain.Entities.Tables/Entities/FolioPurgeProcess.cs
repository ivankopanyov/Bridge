namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FolioPurgeProcess
{
    public string Resort { get; set; }
    public decimal PurgePid { get; set; }
    public string Description { get; set; }
    public DateTime PurgeDate { get; set; }
    public string PurgeStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioPurgeProcess>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FOLIO_PURGE_PROCESS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PurgeDate)
                .HasColumnName("PURGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PurgePid)
                .HasColumnName("PURGE_PID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PurgeStatus)
                .HasColumnName("PURGE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
