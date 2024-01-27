namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GuestLoginUsersVw
{
    public string LoginName { get; set; }
    public decimal NameId { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string NewPassword { get; set; }
    public string SecQuestionCode { get; set; }
    public string SecAnswer { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? LastLogginDate { get; set; }
    public string InsertSource { get; set; }
    public string Comments { get; set; }
    public DateTime? PasswordChangeDate { get; set; }
    public string PwdSystemGenerated { get; set; }
    public DateTime? AccountLocked { get; set; }
    public string ChainCode { get; set; }
    public string Resort { get; set; }
    public string DomainCode { get; set; }
    public string Rowidx { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestLoginUsersVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GUEST_LOGIN_USERS_VW");

            entity.Property(e => e.AccountLocked)
                .HasColumnName("ACCOUNT_LOCKED")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DomainCode)
                .HasColumnName("DOMAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertSource)
                .HasColumnName("INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastLogginDate)
                .HasColumnName("LAST_LOGGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LoginName)
                .IsRequired()
                .HasColumnName("LOGIN_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NewPassword)
                .HasColumnName("NEW_PASSWORD")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PasswordChangeDate)
                .HasColumnName("PASSWORD_CHANGE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PwdSystemGenerated)
                .HasColumnName("PWD_SYSTEM_GENERATED")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rowidx)
                .HasColumnName("ROWIDX")
                .HasColumnType("ROWID")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SecAnswer)
                .HasColumnName("SEC_ANSWER")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SecQuestionCode)
                .HasColumnName("SEC_QUESTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
