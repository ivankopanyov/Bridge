namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidJobTitlesTemplateChn
{
    public string? JobCode { get; set; }
    public string? JobDescription { get; set; }
    public string? ChainCode { get; set; }
    public string? ClosingScriptYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidJobTitlesTemplateChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_JOB_TITLES_TEMPLATE_CHN");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClosingScriptYn)
                .HasColumnName("CLOSING_SCRIPT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.JobCode)
                .IsRequired()
                .HasColumnName("JOB_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.JobDescription)
                .HasColumnName("JOB_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
