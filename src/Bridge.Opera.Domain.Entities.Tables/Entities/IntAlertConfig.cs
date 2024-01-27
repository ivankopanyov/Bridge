namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntAlertConfig
{
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public string AlertGroupCode { get; set; }
    public decimal AlertQueryId { get; set; }
    public string AlertQuery { get; set; }
    public string AlertDescription { get; set; }
    public string Module { get; set; }
    public decimal? TimeInSecsP1 { get; set; }
    public decimal? TimeValP1 { get; set; }
    public string TimeValTuP1 { get; set; }
    public string TimeValP1Yn { get; set; }
    public decimal? TimeInSecsP2 { get; set; }
    public decimal? TimeValP2 { get; set; }
    public string TimeValTuP2 { get; set; }
    public string TimeValP2Yn { get; set; }
    public decimal? AbsValP1 { get; set; }
    public string AbsValP1Yn { get; set; }
    public decimal? AbsValP2 { get; set; }
    public string AbsValP2Yn { get; set; }
    public decimal? PrcValP1 { get; set; }
    public string PrcValP1Yn { get; set; }
    public decimal? PrcValP2 { get; set; }
    public string PrcValP2Yn { get; set; }
    public string AlertEnabledUd { get; set; }
    public DateTime? AlertDefferedUntil { get; set; }
    public DateTime? FirstAlertTime { get; set; }
    public DateTime? LastAlertTime { get; set; }
    public string LastAlertLevel { get; set; }
    public string MaxAlertLevel { get; set; }
    public string QueryDump { get; set; }
    public string SendQueryDumpYn { get; set; }
    public string SendQueryDumpYnOrg { get; set; }
    public string ErrorDump { get; set; }
    public string AlertShortDesc { get; set; }
    public string AlertEsclLevels { get; set; }
    public string AlertEsclIntrL1 { get; set; }
    public string AlertEsclIntrL2 { get; set; }
    public string AlertEsclIntrL3 { get; set; }
    public string AlertL1EmailId { get; set; }
    public string AlertL2EmailId { get; set; }
    public string AlertL3EmailId { get; set; }
    public decimal? AlertL1SmsNo { get; set; }
    public decimal? AlertL2SmsNo { get; set; }
    public decimal? AlertL3SmsNo { get; set; }
    public string AlertFmtL1 { get; set; }
    public string AlertFmtL2 { get; set; }
    public string AlertFmtL3 { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntAlertConfig>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_ALERT_CONFIG");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort, e.AlertGroupCode, e.AlertQueryId, e.TimeInSecsP1, e.TimeInSecsP2, e.AbsValP1, e.AbsValP2, e.PrcValP1, e.PrcValP2 })
                .HasName("INT_ALERT_CONFIG_UK")
                .IsUnique();

            entity.Property(e => e.AbsValP1)
                .HasColumnName("ABS_VAL_P1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AbsValP1Yn)
                .HasColumnName("ABS_VAL_P1_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.AbsValP2)
                .HasColumnName("ABS_VAL_P2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AbsValP2Yn)
                .HasColumnName("ABS_VAL_P2_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.AlertDefferedUntil)
                .HasColumnName("ALERT_DEFFERED_UNTIL")
                .HasColumnType("DATE");

            entity.Property(e => e.AlertDescription)
                .IsRequired()
                .HasColumnName("ALERT_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.AlertEnabledUd)
                .IsRequired()
                .HasColumnName("ALERT_ENABLED_UD")
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'NN'");

            entity.Property(e => e.AlertEsclIntrL1)
                .HasColumnName("ALERT_ESCL_INTR_L1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AlertEsclIntrL2)
                .HasColumnName("ALERT_ESCL_INTR_L2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AlertEsclIntrL3)
                .HasColumnName("ALERT_ESCL_INTR_L3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AlertEsclLevels)
                .HasColumnName("ALERT_ESCL_LEVELS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AlertFmtL1)
                .HasColumnName("ALERT_FMT_L1")
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'TEXT'");

            entity.Property(e => e.AlertFmtL2)
                .HasColumnName("ALERT_FMT_L2")
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'TEXT'");

            entity.Property(e => e.AlertFmtL3)
                .HasColumnName("ALERT_FMT_L3")
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'TEXT'");

            entity.Property(e => e.AlertGroupCode)
                .IsRequired()
                .HasColumnName("ALERT_GROUP_CODE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'IP'");

            entity.Property(e => e.AlertL1EmailId)
                .HasColumnName("ALERT_L1_EMAIL_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AlertL1SmsNo)
                .HasColumnName("ALERT_L1_SMS_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AlertL2EmailId)
                .HasColumnName("ALERT_L2_EMAIL_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AlertL2SmsNo)
                .HasColumnName("ALERT_L2_SMS_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AlertL3EmailId)
                .HasColumnName("ALERT_L3_EMAIL_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AlertL3SmsNo)
                .HasColumnName("ALERT_L3_SMS_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AlertQuery)
                .IsRequired()
                .HasColumnName("ALERT_QUERY")
                .IsUnicode(false);

            entity.Property(e => e.AlertQueryId)
                .HasColumnName("ALERT_QUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AlertShortDesc)
                .HasColumnName("ALERT_SHORT_DESC")
                .HasMaxLength(500)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ErrorDump)
                .HasColumnName("ERROR_DUMP")
                .IsUnicode(false);

            entity.Property(e => e.FirstAlertTime)
                .HasColumnName("FIRST_ALERT_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("SYSDATE ");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("UID ");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastAlertLevel)
                .HasColumnName("LAST_ALERT_LEVEL")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.LastAlertTime)
                .HasColumnName("LAST_ALERT_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.MaxAlertLevel)
                .HasColumnName("MAX_ALERT_LEVEL")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .IsUnicode(false);

            entity.Property(e => e.PrcValP1)
                .HasColumnName("PRC_VAL_P1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrcValP1Yn)
                .HasColumnName("PRC_VAL_P1_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.PrcValP2)
                .HasColumnName("PRC_VAL_P2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrcValP2Yn)
                .HasColumnName("PRC_VAL_P2_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.QueryDump)
                .HasColumnName("QUERY_DUMP")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SendQueryDumpYn)
                .HasColumnName("SEND_QUERY_DUMP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.SendQueryDumpYnOrg)
                .HasColumnName("SEND_QUERY_DUMP_YN_ORG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TimeInSecsP1)
                .HasColumnName("TIME_IN_SECS_P1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeInSecsP2)
                .HasColumnName("TIME_IN_SECS_P2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeValP1)
                .HasColumnName("TIME_VAL_P1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeValP1Yn)
                .HasColumnName("TIME_VAL_P1_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.TimeValP2)
                .HasColumnName("TIME_VAL_P2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeValP2Yn)
                .HasColumnName("TIME_VAL_P2_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.TimeValTuP1)
                .HasColumnName("TIME_VAL_TU_P1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TimeValTuP2)
                .HasColumnName("TIME_VAL_TU_P2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("SYSDATE ");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("UID ");
        });
	}
}
