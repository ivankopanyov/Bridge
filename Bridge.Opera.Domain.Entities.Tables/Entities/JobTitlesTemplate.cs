namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobTitlesTemplate
{
    public string JobCode { get; set; }
    public string JobDescription { get; set; }
    public string ChainCode { get; set; }
    public string ClosingScriptYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobTitlesTemplate>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.JobCode })
                .HasName("JOB_TITLES_TEMPLATE_PK");

            entity.ToTable("JOB_TITLES_TEMPLATE");

            entity.HasIndex(e => e.JobDescription)
                .HasName("JOB_TITLES_TEMPLATE_DESC_IDX");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.JobCode)
                .HasColumnName("JOB_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClosingScriptYn)
                .HasColumnName("CLOSING_SCRIPT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.JobDescription)
                .HasColumnName("JOB_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
