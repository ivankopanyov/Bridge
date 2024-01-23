namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OvosResvTransactionsView
{
    public decimal Id { get; set; }
    public string Resort { get; set; }
    public decimal ContractId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string RecordType { get; set; }
    public DateTime BusinessDate { get; set; }
    public string Room { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? NameId { get; set; }
    public decimal? RecGroupId { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? Amount { get; set; }
    public decimal? PctShare { get; set; }
    public decimal? Sequence { get; set; }
    public decimal? DeductId { get; set; }
    public string DeductCode { get; set; }
    public string Remarks { get; set; }
    public string CorrectAdjustFlag { get; set; }
    public string AdjCode { get; set; }
    public string AdjDesc { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public string StatementGroup { get; set; }
    public decimal? TrustAccPoints { get; set; }
    public decimal? DaysInRental { get; set; }
    public decimal? RefTrxNo { get; set; }
    public string ElementCode { get; set; }
    public DateTime? TrxForDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosResvTransactionsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OVOS_RESV_TRANSACTIONS_VIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjCode)
                .HasColumnName("ADJ_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AdjDesc)
                .HasColumnName("ADJ_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CorrectAdjustFlag)
                .HasColumnName("CORRECT_ADJUST_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DaysInRental)
                .HasColumnName("DAYS_IN_RENTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeductCode)
                .HasColumnName("DEDUCT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeductId)
                .HasColumnName("DEDUCT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElementCode)
                .HasColumnName("ELEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PctShare)
                .HasColumnName("PCT_SHARE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecGroupId)
                .HasColumnName("REC_GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RefTrxNo)
                .HasColumnName("REF_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatementGroup)
                .HasColumnName("STATEMENT_GROUP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrustAccPoints)
                .HasColumnName("TRUST_ACC_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxForDate)
                .HasColumnName("TRX_FOR_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
