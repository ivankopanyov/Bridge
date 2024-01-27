namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortSguestConfig
{
    public string Resort { get; set; }
    public string OperaSiteId { get; set; }
    public string OperaSitePassword { get; set; }
    public string SguestApplicationUrl { get; set; }
    public string SguestTargetMemberCode { get; set; }
    public decimal SguestSsoTokenMinExpTime { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string CommPrefWsUrl { get; set; }
    public decimal? CommPrefWsTimeoutSeconds { get; set; }
    public string TranslationWsUrl { get; set; }
    public decimal? TranslationWsTimeoutSeconds { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortSguestConfig>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("RESORT_SGUEST_CONFIG_PK");

            entity.ToTable("RESORT_SGUEST_CONFIG");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommPrefWsTimeoutSeconds)
                .HasColumnName("COMM_PREF_WS_TIMEOUT_SECONDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommPrefWsUrl)
                .HasColumnName("COMM_PREF_WS_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaSiteId)
                .HasColumnName("OPERA_SITE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OperaSitePassword)
                .IsRequired()
                .HasColumnName("OPERA_SITE_PASSWORD")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SguestApplicationUrl)
                .IsRequired()
                .HasColumnName("SGUEST_APPLICATION_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SguestSsoTokenMinExpTime)
                .HasColumnName("SGUEST_SSO_TOKEN_MIN_EXP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SguestTargetMemberCode)
                .IsRequired()
                .HasColumnName("SGUEST_TARGET_MEMBER_CODE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.TranslationWsTimeoutSeconds)
                .HasColumnName("TRANSLATION_WS_TIMEOUT_SECONDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TranslationWsUrl)
                .HasColumnName("TRANSLATION_WS_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
