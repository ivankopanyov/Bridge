namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofRevenueTaxRecords
{
    public string AccountPeriod { get; set; }
    public decimal? UserId { get; set; }
    public string UserName { get; set; }
    public DateTime? TrxDate { get; set; }
    public string TrxCode { get; set; }
    public string Description { get; set; }
    public decimal? GrossAmount { get; set; }
    public string GrossAmtFlag { get; set; }
    public decimal? NetAmount { get; set; }
    public string NetAmtFlag { get; set; }
    public decimal? Tax1 { get; set; }
    public decimal? Tax2 { get; set; }
    public decimal? Tax3 { get; set; }
    public decimal? Tax4 { get; set; }
    public decimal? Tax5 { get; set; }
    public decimal? Tax6 { get; set; }
    public decimal? Tax7 { get; set; }
    public decimal? Tax8 { get; set; }
    public decimal? Tax9 { get; set; }
    public decimal? Tax10 { get; set; }
    public decimal? Tax11 { get; set; }
    public decimal? Tax12 { get; set; }
    public decimal? Tax13 { get; set; }
    public decimal? Tax14 { get; set; }
    public decimal? Tax15 { get; set; }
    public decimal? Tax16 { get; set; }
    public decimal? Tax17 { get; set; }
    public decimal? Tax18 { get; set; }
    public decimal? Tax19 { get; set; }
    public decimal? Tax20 { get; set; }
    public string TrxCodeType { get; set; }
    public string TcGroup { get; set; }
    public string TcSubgroup { get; set; }
    public string ArInd { get; set; }
    public decimal? RevBucketId { get; set; }
    public string CashInd { get; set; }
    public string ManualPostYn { get; set; }
    public string IndRevenueGp { get; set; }
    public string ArrangeCode { get; set; }
    public decimal? ExpenseFolio { get; set; }
    public decimal? GroupFolio { get; set; }
    public string BofCode1 { get; set; }
    public string BofCode2 { get; set; }
    public string BofCode3 { get; set; }
    public string BofCode4 { get; set; }
    public string BofCode5 { get; set; }
    public decimal? BofCode6 { get; set; }
    public decimal? BofCode7 { get; set; }
    public decimal? BofCode8 { get; set; }
    public decimal? BofCode9 { get; set; }
    public decimal? BofCode10 { get; set; }
    public DateTime? BofCode11 { get; set; }
    public DateTime? BofCode12 { get; set; }
    public DateTime? BofCode13 { get; set; }
    public DateTime? BofCode14 { get; set; }
    public DateTime? BofCode15 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofRevenueTaxRecords>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_REVENUE_TAX_RECORDS");

            entity.Property(e => e.AccountPeriod)
                .HasColumnName("ACCOUNT_PERIOD")
                .IsUnicode(false);

            entity.Property(e => e.ArInd)
                .HasColumnName("AR_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArrangeCode)
                .HasColumnName("ARRANGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode1)
                .HasColumnName("BOF_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode10)
                .HasColumnName("BOF_CODE10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode11)
                .HasColumnName("BOF_CODE11")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode12)
                .HasColumnName("BOF_CODE12")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode13)
                .HasColumnName("BOF_CODE13")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode14)
                .HasColumnName("BOF_CODE14")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode15)
                .HasColumnName("BOF_CODE15")
                .HasColumnType("DATE");

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
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode7)
                .HasColumnName("BOF_CODE7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode8)
                .HasColumnName("BOF_CODE8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode9)
                .HasColumnName("BOF_CODE9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashInd)
                .HasColumnName("CASH_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpenseFolio)
                .HasColumnName("EXPENSE_FOLIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmtFlag)
                .HasColumnName("GROSS_AMT_FLAG")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.GroupFolio)
                .HasColumnName("GROUP_FOLIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRevenueGp)
                .HasColumnName("IND_REVENUE_GP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ManualPostYn)
                .HasColumnName("MANUAL_POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmtFlag)
                .HasColumnName("NET_AMT_FLAG")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.RevBucketId)
                .HasColumnName("REV_BUCKET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax1)
                .HasColumnName("TAX1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax10)
                .HasColumnName("TAX10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax11)
                .HasColumnName("TAX11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax12)
                .HasColumnName("TAX12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax13)
                .HasColumnName("TAX13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax14)
                .HasColumnName("TAX14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax15)
                .HasColumnName("TAX15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax16)
                .HasColumnName("TAX16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax17)
                .HasColumnName("TAX17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax18)
                .HasColumnName("TAX18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax19)
                .HasColumnName("TAX19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax2)
                .HasColumnName("TAX2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax20)
                .HasColumnName("TAX20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax3)
                .HasColumnName("TAX3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax4)
                .HasColumnName("TAX4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax5)
                .HasColumnName("TAX5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax6)
                .HasColumnName("TAX6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax7)
                .HasColumnName("TAX7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax8)
                .HasColumnName("TAX8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax9)
                .HasColumnName("TAX9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);
        });
	}
}
