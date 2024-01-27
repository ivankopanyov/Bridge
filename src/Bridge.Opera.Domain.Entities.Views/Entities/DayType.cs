namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DayType
{
    public string DtCode { get; set; }
    public string DtDesc { get; set; }
    public decimal? DtAdder { get; set; }
    public string DtRemarks { get; set; }
    public decimal? DtMultiplier { get; set; }
    public decimal? SellSequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DayType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DAY_TYPE");

            entity.Property(e => e.DtAdder)
                .HasColumnName("DT_ADDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtCode)
                .IsRequired()
                .HasColumnName("DT_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
