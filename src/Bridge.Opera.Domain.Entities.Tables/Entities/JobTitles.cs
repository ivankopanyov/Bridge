namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobTitles
{
    public string? Resort { get; set; }
    public string? JobCode { get; set; }
    public string? JobDescription { get; set; }
    public string? ClosingScriptYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobTitles>(entity =>
        {
            entity.HasKey(e => new { e.JobCode, e.Resort })
                .HasName("JT_PK");

            entity.ToTable("JOB_TITLES");

            entity.Property(e => e.JobCode)
                .HasColumnName("JOB_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClosingScriptYn)
                .HasColumnName("CLOSING_SCRIPT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.JobDescription)
                .IsRequired()
                .HasColumnName("JOB_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
