namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntAlertGrpConfig
{
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? GrpCode { get; set; }
    public string? GrpEsclIntrL1 { get; set; }
    public string? GrpEsclIntrL2 { get; set; }
    public string? GrpEsclIntrL3 { get; set; }
    public string? GrpL1EmailId { get; set; }
    public string? GrpL2EmailId { get; set; }
    public string? GrpL3EmailId { get; set; }
    public decimal? GrpL1SmsNo { get; set; }
    public decimal? GrpL2SmsNo { get; set; }
    public decimal? GrpL3SmsNo { get; set; }
    public string? GrpAltFmtL1 { get; set; }
    public string? GrpAltFmtL2 { get; set; }
    public string? GrpAltFmtL3 { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntAlertGrpConfig>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_ALERT_GRP_CONFIG");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort, e.GrpCode })
                .HasName("INT_ALERT_GRP_CONFIG_UK")
                .IsUnique();

            entity.Property(e => e.GrpAltFmtL1)
                .HasColumnName("GRP_ALT_FMT_L1")
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'TEXT'");

            entity.Property(e => e.GrpAltFmtL2)
                .HasColumnName("GRP_ALT_FMT_L2")
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'TEXT'");

            entity.Property(e => e.GrpAltFmtL3)
                .HasColumnName("GRP_ALT_FMT_L3")
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'TEXT'");

            entity.Property(e => e.GrpCode)
                .IsRequired()
                .HasColumnName("GRP_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.GrpEsclIntrL1)
                .HasColumnName("GRP_ESCL_INTR_L1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrpEsclIntrL2)
                .HasColumnName("GRP_ESCL_INTR_L2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrpEsclIntrL3)
                .HasColumnName("GRP_ESCL_INTR_L3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrpL1EmailId)
                .HasColumnName("GRP_L1_EMAIL_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrpL1SmsNo)
                .HasColumnName("GRP_L1_SMS_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpL2EmailId)
                .HasColumnName("GRP_L2_EMAIL_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrpL2SmsNo)
                .HasColumnName("GRP_L2_SMS_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpL3EmailId)
                .HasColumnName("GRP_L3_EMAIL_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrpL3SmsNo)
                .HasColumnName("GRP_L3_SMS_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
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
