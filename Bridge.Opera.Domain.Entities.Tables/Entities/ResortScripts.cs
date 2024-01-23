namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortScripts
{
    public string ResortType { get; set; }
    public string Resort { get; set; }
    public decimal ScriptId { get; set; }
    public string LanguageCode { get; set; }
    public string MembershipType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortScripts>(entity =>
        {
            entity.HasKey(e => new { e.ResortType, e.Resort, e.ScriptId, e.LanguageCode, e.MembershipType })
                .HasName("RESORT_SCRIPTS_PK");

            entity.ToTable("RESORT_SCRIPTS");

            entity.HasIndex(e => new { e.ScriptId, e.LanguageCode, e.MembershipType })
                .HasName("RESORT_SCRIPTS_IND1");

            entity.Property(e => e.ResortType)
                .HasColumnName("RESORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

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
        });
	}
}
