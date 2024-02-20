namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileGuestLogins
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? LoginName { get; set; }
    public string? Password { get; set; }
    public string? SecQuestionCode { get; set; }
    public string? SecAnswer { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? PasswordChangeDate { get; set; }
    public string? PwdSystemGenerated { get; set; }
    public DateTime? AccountLocked { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileGuestLogins>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_GUEST_LOGINS");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId, e.LoginName })
                .HasName("STAGE_PROFILE_GUTDOMAIN_IDX1");

            entity.Property(e => e.AccountLocked)
                .HasColumnName("ACCOUNT_LOCKED")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LoginName)
                .IsRequired()
                .HasColumnName("LOGIN_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PasswordChangeDate)
                .HasColumnName("PASSWORD_CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PwdSystemGenerated)
                .HasColumnName("PWD_SYSTEM_GENERATED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SecAnswer)
                .HasColumnName("SEC_ANSWER")
                .IsUnicode(false);

            entity.Property(e => e.SecQuestionCode)
                .HasColumnName("SEC_QUESTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
