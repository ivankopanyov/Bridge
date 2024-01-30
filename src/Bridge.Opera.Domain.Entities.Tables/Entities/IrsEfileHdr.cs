namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IrsEfileHdr
{
    public string? Resort { get; set; }
    public string? ReturnType { get; set; }
    public string? TxForeignInd { get; set; }
    public string? TxTin { get; set; }
    public string? TxCtrlCode { get; set; }
    public string? TxName1 { get; set; }
    public string? TxName2 { get; set; }
    public string? TxCompanyName1 { get; set; }
    public string? TxCompanyName2 { get; set; }
    public string? TxCompanyAddress { get; set; }
    public string? TxCompanyCity { get; set; }
    public string? TxCompanyState { get; set; }
    public string? TxCompanyZip { get; set; }
    public string? TxContactName { get; set; }
    public string? TxContactPhone { get; set; }
    public string? TxContactEmail { get; set; }
    public string? TxMediaNo { get; set; }
    public string? TxIsPayerYn { get; set; }
    public string? PayerTin { get; set; }
    public string? PayerNameCtrl { get; set; }
    public string? FedStateCombinedInd { get; set; }
    public string? PayerForeignInd { get; set; }
    public string? FirstPayerName { get; set; }
    public string? SecondPayerName { get; set; }
    public string? TransferAgentInd { get; set; }
    public string? PayerAddress { get; set; }
    public string? PayerCity { get; set; }
    public string? PayerState { get; set; }
    public string? PayerZip { get; set; }
    public string? PayerPhone { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IrsEfileHdr>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ReturnType })
                .HasName("IRS_EFILE_HDR_PK");

            entity.ToTable("IRS_EFILE_HDR");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReturnType)
                .HasColumnName("RETURN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FedStateCombinedInd)
                .HasColumnName("FED_STATE_COMBINED_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FirstPayerName)
                .HasColumnName("FIRST_PAYER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayerAddress)
                .HasColumnName("PAYER_ADDRESS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PayerCity)
                .HasColumnName("PAYER_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PayerForeignInd)
                .HasColumnName("PAYER_FOREIGN_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PayerNameCtrl)
                .HasColumnName("PAYER_NAME_CTRL")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.PayerPhone)
                .HasColumnName("PAYER_PHONE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.PayerState)
                .HasColumnName("PAYER_STATE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.PayerTin)
                .HasColumnName("PAYER_TIN")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.PayerZip)
                .HasColumnName("PAYER_ZIP")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.SecondPayerName)
                .HasColumnName("SECOND_PAYER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TransferAgentInd)
                .HasColumnName("TRANSFER_AGENT_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TxCompanyAddress)
                .HasColumnName("TX_COMPANY_ADDRESS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TxCompanyCity)
                .HasColumnName("TX_COMPANY_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TxCompanyName1)
                .HasColumnName("TX_COMPANY_NAME1")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TxCompanyName2)
                .HasColumnName("TX_COMPANY_NAME2")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TxCompanyState)
                .HasColumnName("TX_COMPANY_STATE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TxCompanyZip)
                .HasColumnName("TX_COMPANY_ZIP")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.TxContactEmail)
                .HasColumnName("TX_CONTACT_EMAIL")
                .HasMaxLength(35)
                .IsUnicode(false);

            entity.Property(e => e.TxContactName)
                .HasColumnName("TX_CONTACT_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TxContactPhone)
                .HasColumnName("TX_CONTACT_PHONE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.TxCtrlCode)
                .HasColumnName("TX_CTRL_CODE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TxForeignInd)
                .HasColumnName("TX_FOREIGN_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TxIsPayerYn)
                .HasColumnName("TX_IS_PAYER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TxMediaNo)
                .HasColumnName("TX_MEDIA_NO")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.TxName1)
                .HasColumnName("TX_NAME1")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TxName2)
                .HasColumnName("TX_NAME2")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TxTin)
                .HasColumnName("TX_TIN")
                .HasMaxLength(9)
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
