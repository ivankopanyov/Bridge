namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortCommissionDetailVw
{
    public string Resort { get; set; }
    public string CommissionCode { get; set; }
    public string TrxCode { get; set; }
    public string FlatPercentage { get; set; }
    public decimal? Amount { get; set; }
    public string PerStayYn { get; set; }
    public string PerNtYn { get; set; }
    public string PerUseYn { get; set; }
    public string NetYn { get; set; }
    public decimal? Vat { get; set; }
    public decimal? WEAmt { get; set; }
    public string UdfCalculation { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string TrxCodeDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortCommissionDetailVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_COMMISSION_DETAIL_VW");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionCode)
                .IsRequired()
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FlatPercentage)
                .HasColumnName("FLAT_PERCENTAGE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetYn)
                .HasColumnName("NET_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PerNtYn)
                .HasColumnName("PER_NT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PerStayYn)
                .HasColumnName("PER_STAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PerUseYn)
                .HasColumnName("PER_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeDesc)
                .HasColumnName("TRX_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UdfCalculation)
                .HasColumnName("UDF_CALCULATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Vat)
                .HasColumnName("VAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WEAmt)
                .HasColumnName("W_E_AMT")
                .HasColumnType("NUMBER");
        });
	}
}
