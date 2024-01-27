namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CcPaymentTransactions
{
    public string Resort { get; set; }
    public decimal SeqNo { get; set; }
    public string ParameterName { get; set; }
    public string ParameterType { get; set; }
    public string ParameterValue { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

    public virtual CcTransactionLog SeqNoNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CcPaymentTransactions>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CC_PAYMENT_TRANSACTIONS");

            entity.HasIndex(e => e.SeqNo)
                .HasName("CC_PAYMENT_TRX_SEQNO_IDX");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterType)
                .HasColumnName("PARAMETER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterValue)
                .HasColumnName("PARAMETER_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(CcTransactionLog)))
				entity.Ignore(e => e.SeqNoNavigation);
			else
	            entity.HasOne(d => d.SeqNoNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.SeqNo)
	                .HasConstraintName("CCPT_CCTL_FK");
        });
	}
}
