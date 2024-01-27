namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosContractFees
{
    public decimal Id { get; set; }
    public string Resort { get; set; }
    public decimal ContractId { get; set; }
    public string Code { get; set; }
    public string Frequency { get; set; }
    public string Formula { get; set; }
    public decimal? Amount { get; set; }
    public string TrxCode { get; set; }
    public string AutoPost { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string PostTo { get; set; }
    public string OccupiedBy { get; set; }
    public decimal? AccountCode { get; set; }
    public string Schedule { get; set; }
    public string AfterSplitYn { get; set; }
    public decimal? CalcSequenceNo { get; set; }

    public virtual OvosContracts OvosContracts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosContractFees>(entity =>
        {
            entity.ToTable("OVOS_CONTRACT_FEES");

            entity.HasIndex(e => new { e.Resort, e.AccountCode })
                .HasName("OVOS_CONTRACT_FEES_ACCOUNT_IND");

            entity.HasIndex(e => new { e.Resort, e.ContractId })
                .HasName("OCF_IDX1");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AfterSplitYn)
                .HasColumnName("AFTER_SPLIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoPost)
                .HasColumnName("AUTO_POST")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.CalcSequenceNo)
                .HasColumnName("CALC_SEQUENCE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Formula)
                .HasColumnName("FORMULA")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccupiedBy)
                .HasColumnName("OCCUPIED_BY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostTo)
                .HasColumnName("POST_TO")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Schedule)
                .HasColumnName("SCHEDULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OvosContracts)))
				entity.Ignore(e => e.OvosContracts);
			else
	            entity.HasOne(d => d.OvosContracts)
	                .WithMany(p => p.OvosContractFees)
	                .HasForeignKey(d => new { d.Resort, d.ContractId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCF_CONTRACTS_FK");
        });
	}
}
