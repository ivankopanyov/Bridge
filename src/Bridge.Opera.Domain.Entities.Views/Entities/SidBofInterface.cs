namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidBofInterface
{
    public decimal BofInterfaceId { get; set; }
    public string Resort { get; set; }
    public string BofInterfaceName { get; set; }
    public string BofBatchMode { get; set; }
    public string BofAccPeriodYn { get; set; }
    public string BofCode1 { get; set; }
    public string BofCode2 { get; set; }
    public string BofCode3 { get; set; }
    public string BofCode4 { get; set; }
    public string BofCode5 { get; set; }
    public string BofCode6 { get; set; }
    public string BofCode7 { get; set; }
    public string BofCode8 { get; set; }
    public string BofCode9 { get; set; }
    public string BofCode10 { get; set; }
    public string BofCode11 { get; set; }
    public string BofCode12 { get; set; }
    public string BofCode13 { get; set; }
    public string BofCode14 { get; set; }
    public string BofCode15 { get; set; }
    public DateTime? LstRevTransDate { get; set; }
    public DateTime? LstCityTransDate { get; set; }
    public decimal? LstRevSeqNo { get; set; }
    public decimal? LstCitySeqNo { get; set; }
    public string BofActiveFlag { get; set; }
    public string CanDeleteYn { get; set; }
    public decimal? LstMktSeqNo { get; set; }
    public DateTime? LstMktTransDate { get; set; }
    public decimal? LstStaSeqNo { get; set; }
    public DateTime? LstStaTransDate { get; set; }
    public string OxiInterfaceId { get; set; }
    public string OxiUploadYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidBofInterface>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_BOF$INTERFACE");

            entity.Property(e => e.BofAccPeriodYn)
                .HasColumnName("BOF_ACC_PERIOD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BofActiveFlag)
                .HasColumnName("BOF_ACTIVE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BofBatchMode)
                .HasColumnName("BOF_BATCH_MODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BofCode1)
                .HasColumnName("BOF_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode10)
                .HasColumnName("BOF_CODE10")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode11)
                .HasColumnName("BOF_CODE11")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode12)
                .HasColumnName("BOF_CODE12")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode13)
                .HasColumnName("BOF_CODE13")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode14)
                .HasColumnName("BOF_CODE14")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode15)
                .HasColumnName("BOF_CODE15")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode2)
                .HasColumnName("BOF_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode3)
                .HasColumnName("BOF_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode4)
                .HasColumnName("BOF_CODE4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode5)
                .HasColumnName("BOF_CODE5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode6)
                .HasColumnName("BOF_CODE6")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode7)
                .HasColumnName("BOF_CODE7")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode8)
                .HasColumnName("BOF_CODE8")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofCode9)
                .HasColumnName("BOF_CODE9")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.BofInterfaceId)
                .HasColumnName("BOF_INTERFACE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofInterfaceName)
                .HasColumnName("BOF_INTERFACE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LstCitySeqNo)
                .HasColumnName("LST_CITY_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LstCityTransDate)
                .HasColumnName("LST_CITY_TRANS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LstMktSeqNo)
                .HasColumnName("LST_MKT_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LstMktTransDate)
                .HasColumnName("LST_MKT_TRANS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LstRevSeqNo)
                .HasColumnName("LST_REV_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LstRevTransDate)
                .HasColumnName("LST_REV_TRANS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LstStaSeqNo)
                .HasColumnName("LST_STA_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LstStaTransDate)
                .HasColumnName("LST_STA_TRANS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OxiInterfaceId)
                .HasColumnName("OXI_INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OxiUploadYn)
                .HasColumnName("OXI_UPLOAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
