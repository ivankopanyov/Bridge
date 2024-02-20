namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsResortQuotOffset
{
    public string? Resort { get; set; }
    public string? OffsetCode { get; set; }
    public string? OffsetDesc { get; set; }
    public decimal? Offset { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OffsetAmt { get; set; }
    public string? OffsetAmtCalcMethod { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsResortQuotOffset>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.OffsetCode })
                .HasName("ORMS_RESORT_QUOT_OFF_PK");

            entity.ToTable("ORMS_RESORT_QUOT_OFFSET");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OffsetCode)
                .HasColumnName("OFFSET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Offset)
                .HasColumnName("OFFSET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetAmt)
                .HasColumnName("OFFSET_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetAmtCalcMethod)
                .HasColumnName("OFFSET_AMT_CALC_METHOD")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OffsetDesc)
                .IsRequired()
                .HasColumnName("OFFSET_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
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
