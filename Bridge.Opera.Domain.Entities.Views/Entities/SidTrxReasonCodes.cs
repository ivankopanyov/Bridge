namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidTrxReasonCodes
{
    public string Resort { get; set; }
    public string AdjustmentType { get; set; }
    public string TranReasonCode { get; set; }
    public string TranReasonDesc { get; set; }
    public string TranCodeType { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidTrxReasonCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_TRX$_REASON_CODES");

            entity.Property(e => e.AdjustmentType)
                .HasColumnName("ADJUSTMENT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TranCodeType)
                .IsRequired()
                .HasColumnName("TRAN_CODE_TYPE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TranReasonCode)
                .IsRequired()
                .HasColumnName("TRAN_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TranReasonDesc)
                .HasColumnName("TRAN_REASON_DESC")
                .HasMaxLength(2000)
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
