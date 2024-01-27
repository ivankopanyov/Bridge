namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaScript
{
    public decimal ScriptId { get; set; }
    public string ScriptText { get; set; }
    public string LanguageCode { get; set; }
    public string MembershipType { get; set; }
    public string ScriptType { get; set; }
    public string ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaScript>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.ScriptId, e.LanguageCode, e.MembershipType })
                .HasName("OPERA_SCRIPT_PK");

            entity.ToTable("OPERA_SCRIPT");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScriptId)
                .HasColumnName("SCRIPT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'E'");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'NONE'");

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
