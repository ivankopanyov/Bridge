namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpGbeChargesGrp
{
    public decimal? ExportId { get; set; }
    public DateTime? ChargeDate { get; set; }
    public string? GbeType { get; set; }
    public string? ChargeCodeNumber { get; set; }
    public string? ChargeCodeDescription { get; set; }
    public string? ChargeCodeGroup { get; set; }
    public string? ChargeCodeSubgroup { get; set; }
    public string? ChargeDescription { get; set; }
    public decimal? WindowNumber { get; set; }
    public string? ChargeSource { get; set; }
    public string? ChargeReference { get; set; }
    public decimal? ChargeAmount { get; set; }
    public decimal? ChargeGeneratedBy { get; set; }
    public string? ChargeCurrency { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? BlockId { get; set; }
    public decimal? Chargenumber { get; set; }
    public decimal? Originalreservationnumber { get; set; }
    public string? Originalroom { get; set; }
    public string? Originalresvlastname { get; set; }
    public string? Originalresvfirstname { get; set; }
    public DateTime? Businessdate { get; set; }
    public decimal? Packagelinknumber { get; set; }
    public decimal? Transactiongroupnumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpGbeChargesGrp>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_GBE_CHARGES_GRP");

            entity.Property(e => e.BlockId)
                .HasColumnName("BLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Businessdate)
                .HasColumnName("BUSINESSDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChargeAmount)
                .HasColumnName("CHARGE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChargeCodeDescription)
                .HasColumnName("CHARGE_CODE_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChargeCodeGroup)
                .HasColumnName("CHARGE_CODE_GROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChargeCodeNumber)
                .HasColumnName("CHARGE_CODE_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChargeCodeSubgroup)
                .HasColumnName("CHARGE_CODE_SUBGROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChargeCurrency)
                .HasColumnName("CHARGE_CURRENCY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChargeDate)
                .HasColumnName("CHARGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChargeDescription)
                .HasColumnName("CHARGE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ChargeGeneratedBy)
                .HasColumnName("CHARGE_GENERATED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChargeReference)
                .HasColumnName("CHARGE_REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ChargeSource)
                .HasColumnName("CHARGE_SOURCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Chargenumber)
                .HasColumnName("CHARGENUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GbeType)
                .HasColumnName("GBE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Originalreservationnumber)
                .HasColumnName("ORIGINALRESERVATIONNUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Originalresvfirstname)
                .HasColumnName("ORIGINALRESVFIRSTNAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Originalresvlastname)
                .HasColumnName("ORIGINALRESVLASTNAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Originalroom)
                .HasColumnName("ORIGINALROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Packagelinknumber)
                .HasColumnName("PACKAGELINKNUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Transactiongroupnumber)
                .HasColumnName("TRANSACTIONGROUPNUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WindowNumber)
                .HasColumnName("WINDOW_NUMBER")
                .HasColumnType("NUMBER");
        });
	}
}
