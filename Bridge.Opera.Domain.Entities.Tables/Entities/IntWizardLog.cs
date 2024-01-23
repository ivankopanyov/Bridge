namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntWizardLog
{
    public DateTime? LogDate { get; set; }
    public string TraceNotes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntWizardLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_WIZARD_LOG");

            entity.Property(e => e.LogDate)
                .HasColumnName("LOG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TraceNotes)
                .HasColumnName("TRACE_NOTES")
                .IsUnicode(false);
        });
	}
}
