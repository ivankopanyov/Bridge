namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileAdjustments
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public string AdjustmentCode { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? AdjustmentAmount { get; set; }
    public string ValidYn { get; set; }
    public string ErrorDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileAdjustments>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId, e.AdjustmentCode })
                .HasName("STAGE_PROFILE_ADJUSTMENTS_PK");

            entity.ToTable("STAGE_PROFILE_ADJUSTMENTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AdjustmentCode)
                .HasColumnName("ADJUSTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AdjustmentAmount)
                .HasColumnName("ADJUSTMENT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
