namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DayTypeTemplate
{
    public string DtCode { get; set; }
    public string DtDesc { get; set; }
    public string DtRemarks { get; set; }
    public decimal? DtMultiplier { get; set; }
    public decimal? SellSequence { get; set; }
    public decimal? DtAdder { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string DtColor { get; set; }
    public string ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DayTypeTemplate>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.DtCode })
                .HasName("DAY_TYPE_TEMPLATE_PK");

            entity.ToTable("DAY_TYPE_TEMPLATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DtCode)
                .HasColumnName("DT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtAdder)
                .HasColumnName("DT_ADDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtColor)
                .HasColumnName("DT_COLOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DtDesc)
                .IsRequired()
                .HasColumnName("DT_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DtMultiplier)
                .HasColumnName("DT_MULTIPLIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtRemarks)
                .HasColumnName("DT_REMARKS")
                .HasMaxLength(2000)
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

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
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
