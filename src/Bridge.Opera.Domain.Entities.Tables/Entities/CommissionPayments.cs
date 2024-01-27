namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CommissionPayments
{
    public CommissionPayments()
    {
        ComputedCommissions = new HashSet<ComputedCommissions>();
    }

    public string Resort { get; set; }
    public decimal PaymentId { get; set; }
    public decimal TravelAgentId { get; set; }
    public DateTime? PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
    public string ApprovedBy { get; set; }
    public decimal? CommissionAmount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? VatPercnt { get; set; }
    public decimal? TotalCheckAmt { get; set; }
    public decimal? BatchId { get; set; }

    public virtual Name TravelAgent { get; set; }
    public virtual ICollection<ComputedCommissions> ComputedCommissions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CommissionPayments>(entity =>
        {
            entity.HasKey(e => e.PaymentId)
                .HasName("COMMISSION_PAYMENTS_PK");

            entity.ToTable("COMMISSION_PAYMENTS");

            entity.HasIndex(e => e.TravelAgentId)
                .HasName("COMMISSION_PAYMENTS_FK1_IDX");

            entity.HasIndex(e => new { e.BatchId, e.Resort })
                .HasName("COMMISSION_BATCH_IDX");

            entity.HasIndex(e => new { e.Resort, e.TravelAgentId, e.PaymentDate })
                .HasName("TA_COMMISSION_PAYMENT_DATE");

            entity.Property(e => e.PaymentId)
                .HasColumnName("PAYMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovedBy)
                .HasColumnName("APPROVED_BY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionAmount)
                .HasColumnName("COMMISSION_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentDate)
                .HasColumnName("PAYMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalCheckAmt)
                .HasColumnName("TOTAL_CHECK_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VatPercnt)
                .HasColumnName("VAT_PERCNT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.TravelAgent);
			else
	            entity.HasOne(d => d.TravelAgent)
	                .WithMany(p => p.CommissionPayments)
	                .HasForeignKey(d => d.TravelAgentId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("COMMISSION_PAYMENTS_FK1");
        
			if (!types.Contains(typeof(ComputedCommissions)))
				entity.Ignore(e => e.ComputedCommissions);
		});
	}
}
