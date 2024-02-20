namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameDiscountDetails
{
    public decimal? DiscountId { get; set; }
    public string? TrxCode { get; set; }
    public decimal? DiscountAmt { get; set; }
    public decimal? DiscountPct { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameDiscountDetails>(entity =>
        {
            entity.HasKey(e => new { e.DiscountId, e.TrxCode })
                .HasName("NAME_DISCOUNT_DETAIL_PK");

            entity.ToTable("NAME_DISCOUNT_DETAILS");

            entity.Property(e => e.DiscountId)
                .HasColumnName("DISCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DiscountAmt)
                .HasColumnName("DISCOUNT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPct)
                .HasColumnName("DISCOUNT_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
