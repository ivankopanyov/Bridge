namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortCommissionDetail
{
    public string? Resort { get; set; }
    public string? CommissionCode { get; set; }
    public string? TrxCode { get; set; }
    public string? FlatPercentage { get; set; }
    public decimal? Amount { get; set; }
    public string? PerStayYn { get; set; }
    public string? PerNtYn { get; set; }
    public string? PerUseYn { get; set; }
    public string? NetYn { get; set; }
    public decimal? Vat { get; set; }
    public decimal? WEAmt { get; set; }
    public string? UdfCalculation { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

    public virtual ResortCommission ResortCommission { get; set; }
    public virtual TrxCodes TrxCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortCommissionDetail>(entity =>
        {
            entity.HasKey(e => new { e.CommissionCode, e.TrxCode, e.Resort })
                .HasName("RCD_PK");

            entity.ToTable("RESORT_COMMISSION_DETAIL");

            entity.HasIndex(e => new { e.CommissionCode, e.Resort })
                .HasName("RCD_RC_IDX");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("RCD_TC_IDX");

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FlatPercentage)
                .HasColumnName("FLAT_PERCENTAGE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetYn)
                .HasColumnName("NET_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PerNtYn)
                .HasColumnName("PER_NT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PerStayYn)
                .HasColumnName("PER_STAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PerUseYn)
                .HasColumnName("PER_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UdfCalculation)
                .HasColumnName("UDF_CALCULATION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Vat)
                .HasColumnName("VAT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WEAmt)
                .HasColumnName("W_E_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ResortCommission)))
				entity.Ignore(e => e.ResortCommission);
			else
	            entity.HasOne(d => d.ResortCommission)
	                .WithMany(p => p.ResortCommissionDetail)
	                .HasForeignKey(d => new { d.CommissionCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RCD_RC_FK");

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.ResortCommissionDetail)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RCD_TC_FK");
        });
	}
}
