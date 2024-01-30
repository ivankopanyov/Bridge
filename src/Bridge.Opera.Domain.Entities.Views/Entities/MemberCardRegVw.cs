namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberCardRegVw
{
    public string? MemberCardRegCode { get; set; }
    public string? MemberCardRegAction { get; set; }
    public string? MemberCardRegCro { get; set; }
    public string? MemberCardRegResort { get; set; }
    public string? MemberCardRegNo { get; set; }
    public string? SourceType { get; set; }
    public string? AppUser { get; set; }
    public string? AppUserRegCode { get; set; }
    public string? AppUserUniq { get; set; }
    public string? AppUserFirst { get; set; }
    public string? AppUserLast { get; set; }
    public string? AppUserEmail { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? BirthDateStr { get; set; }
    public string? EnvelopeGreeting { get; set; }
    public string? First { get; set; }
    public string? Gender { get; set; }
    public string? Language { get; set; }
    public string? Last { get; set; }
    public string? Middle { get; set; }
    public string? NameCode { get; set; }
    public decimal? NameId { get; set; }
    public string? Sfirst { get; set; }
    public string? Sname { get; set; }
    public string? Suffix { get; set; }
    public string? SxfirstName { get; set; }
    public string? Sxname { get; set; }
    public string? Title { get; set; }
    public decimal? TitleSuffix { get; set; }
    public string? XenvelopeGreeting { get; set; }
    public string? XfirstName { get; set; }
    public string? Xlanguage { get; set; }
    public string? XlastName { get; set; }
    public string? XmiddleName { get; set; }
    public string? Xsalutation { get; set; }
    public string? Xtitle { get; set; }
    public string? ChainCode { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? OrigMembershipLevel { get; set; }
    public string? FinalMembershipLevel { get; set; }
    public string? NameOnCard { get; set; }
    public DateTime? OrigExpirationDate { get; set; }
    public DateTime? FinalExpirationDate { get; set; }
    public string? EnrollmentCode { get; set; }
    public DateTime? PaymentDate { get; set; }
    public string? FeeCode { get; set; }
    public decimal? FeeAmount { get; set; }
    public string? PaymentComments { get; set; }
    public string? CreditCardType { get; set; }
    public string? PaymentMethod { get; set; }
    public decimal? FeeRecId { get; set; }
    public decimal? MatchPointsUpperThershold { get; set; }
    public decimal? MatchPointsLowerThershold { get; set; }
    public string? RuleCode { get; set; }
    public string? ValidYn { get; set; }
    public string? ErrorDesc { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? RecordStatus { get; set; }
    public DateTime? JoinedDate { get; set; }
    public decimal? BatchId { get; set; }
    public DateTime? ImportDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberCardRegVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_CARD_REG_VW");

            entity.Property(e => e.AppUser)
                .IsRequired()
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppUserEmail)
                .HasColumnName("APP_USER_EMAIL")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppUserFirst)
                .HasColumnName("APP_USER_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppUserLast)
                .HasColumnName("APP_USER_LAST")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppUserRegCode)
                .IsRequired()
                .HasColumnName("APP_USER_REG_CODE")
                .HasMaxLength(60)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppUserUniq)
                .IsRequired()
                .HasColumnName("APP_USER_UNIQ")
                .HasMaxLength(60)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthDateStr)
                .HasColumnName("BIRTH_DATE_STR")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EnrollmentCode)
                .HasColumnName("ENROLLMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EnvelopeGreeting)
                .HasColumnName("ENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FeeAmount)
                .HasColumnName("FEE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FeeCode)
                .HasColumnName("FEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FeeRecId)
                .HasColumnName("FEE_REC_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FinalExpirationDate)
                .HasColumnName("FINAL_EXPIRATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FinalMembershipLevel)
                .HasColumnName("FINAL_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JoinedDate)
                .HasColumnName("JOINED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MatchPointsLowerThershold)
                .HasColumnName("MATCH_POINTS_LOWER_THERSHOLD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MatchPointsUpperThershold)
                .HasColumnName("MATCH_POINTS_UPPER_THERSHOLD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemberCardRegAction)
                .IsRequired()
                .HasColumnName("MEMBER_CARD_REG_ACTION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemberCardRegCode)
                .IsRequired()
                .HasColumnName("MEMBER_CARD_REG_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemberCardRegCro)
                .HasColumnName("MEMBER_CARD_REG_CRO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemberCardRegNo)
                .HasColumnName("MEMBER_CARD_REG_NO")
                .HasMaxLength(60)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemberCardRegResort)
                .IsRequired()
                .HasColumnName("MEMBER_CARD_REG_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameOnCard)
                .HasColumnName("NAME_ON_CARD")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrigExpirationDate)
                .HasColumnName("ORIG_EXPIRATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrigMembershipLevel)
                .HasColumnName("ORIG_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentComments)
                .HasColumnName("PAYMENT_COMMENTS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentDate)
                .HasColumnName("PAYMENT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecordStatus)
                .HasColumnName("RECORD_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SourceType)
                .IsRequired()
                .HasColumnName("SOURCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Suffix)
                .HasColumnName("SUFFIX")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TitleSuffix)
                .HasColumnName("TITLE_SUFFIX")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.XenvelopeGreeting)
                .HasColumnName("XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xlanguage)
                .HasColumnName("XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.XmiddleName)
                .HasColumnName("XMIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xsalutation)
                .HasColumnName("XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtitle)
                .HasColumnName("XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
