namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcUnitCharge
{
    public decimal? IfcCtrlId { get; set; }
    public string? TrunkId { get; set; }
    public string? LineType { get; set; }
    public string? VipCode { get; set; }
    public decimal? StartUnit { get; set; }
    public decimal? EndUnit { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? Tariff { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcUnitCharge>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_UNIT_CHARGE");

            entity.HasIndex(e => new { e.IfcCtrlId, e.TrunkId, e.LineType, e.VipCode, e.StartUnit })
                .HasName("IFC_UNIT_CHARGE_IDX");

            entity.Property(e => e.EndUnit)
                .HasColumnName("END_UNIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LineType)
                .HasColumnName("LINE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartUnit)
                .HasColumnName("START_UNIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tariff)
                .HasColumnName("TARIFF")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrunkId)
                .HasColumnName("TRUNK_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.VipCode)
                .HasColumnName("VIP_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
