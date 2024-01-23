namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpCreditCardDetails
{
    public decimal ExpDataId { get; set; }
    public decimal ExpDataDtlId { get; set; }
    public decimal ExpSeqNo { get; set; }
    public string CreditCardNumber { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? CreditCardNumberLength { get; set; }

    public virtual ExpDataDtl ExpData { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpCreditCardDetails>(entity =>
        {
            entity.HasKey(e => new { e.ExpDataId, e.ExpDataDtlId, e.ExpSeqNo })
                .HasName("EXPCCD_PK");

            entity.ToTable("EXP_CREDIT_CARD_DETAILS");

            entity.HasIndex(e => new { e.ExpDataId, e.ExpSeqNo })
                .HasName("EXP_CCD_SEQ");

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpDataDtlId)
                .HasColumnName("EXP_DATA_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpSeqNo)
                .HasColumnName("EXP_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumberLength)
                .HasColumnName("CREDIT_CARD_NUMBER_LENGTH")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ExpDataDtl)))
				entity.Ignore(e => e.ExpData);
			else
	            entity.HasOne(d => d.ExpData)
	                .WithMany(p => p.ExpCreditCardDetails)
	                .HasForeignKey(d => new { d.ExpDataId, d.ExpDataDtlId })
	                .HasConstraintName("EXPCCD_EDL_FK");
        });
	}
}
