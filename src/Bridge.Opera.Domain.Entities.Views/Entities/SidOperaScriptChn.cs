namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOperaScriptChn
{
    public decimal? ScriptId { get; set; }
    public string? ScriptText { get; set; }
    public string? LanguageCode { get; set; }
    public string? MembershipType { get; set; }
    public string? ScriptType { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOperaScriptChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OPERA_SCRIPT_CHN");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScriptId)
                .HasColumnName("SCRIPT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScriptText)
                .HasColumnName("SCRIPT_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.ScriptType)
                .HasColumnName("SCRIPT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
