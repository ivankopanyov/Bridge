namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class O2oLog
{
    public string? ProcId { get; set; }
    public decimal? LogLine { get; set; }
    public string? EntryTime { get; set; }
    public string? LogTxt { get; set; }
    public string? O2oMigId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2oLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("O2O_LOG");

            entity.Property(e => e.EntryTime)
                .IsRequired()
                .HasColumnName("ENTRY_TIME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LogLine)
                .HasColumnName("LOG_LINE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LogTxt)
                .HasColumnName("LOG_TXT")
                .IsUnicode(false);

            entity.Property(e => e.O2oMigId)
                .HasColumnName("O2O_MIG_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcId)
                .IsRequired()
                .HasColumnName("PROC_ID")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
