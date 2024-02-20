namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPdRateDimVw
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? RateCode { get; set; }
    public string? RateDesc { get; set; }
    public string? RateCategory { get; set; }
    public string? RateCategoryDesc { get; set; }
    public string? RateClass { get; set; }
    public string? RateClassDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? YieldableYn { get; set; }
    public string? NegotiatedYn { get; set; }
    public string? ComplimentaryYn { get; set; }
    public string? HouseUseYn { get; set; }
    public string? GdsAllowedYn { get; set; }
    public string? LoyaltyProgramYn { get; set; }
    public string? CustomCol1 { get; set; }
    public string? CustomDesc1 { get; set; }
    public string? CustomLabel1 { get; set; }
    public string? CustomCol2 { get; set; }
    public string? CustomDesc2 { get; set; }
    public string? CustomLabel2 { get; set; }
    public string? CustomCol3 { get; set; }
    public string? CustomDesc3 { get; set; }
    public string? CustomLabel3 { get; set; }
    public string? CustomCol4 { get; set; }
    public string? CustomDesc4 { get; set; }
    public string? CustomLabel4 { get; set; }
    public string? CustomCol5 { get; set; }
    public string? CustomDesc5 { get; set; }
    public string? CustomLabel5 { get; set; }
    public string? CustomCol6 { get; set; }
    public string? CustomDesc6 { get; set; }
    public string? CustomLabel6 { get; set; }
    public string? CustomCol7 { get; set; }
    public string? CustomDesc7 { get; set; }
    public string? CustomLabel7 { get; set; }
    public string? CustomCol8 { get; set; }
    public string? CustomDesc8 { get; set; }
    public string? CustomLabel8 { get; set; }
    public string? CustomCol9 { get; set; }
    public string? CustomDesc9 { get; set; }
    public string? CustomLabel9 { get; set; }
    public string? CustomCol10 { get; set; }
    public string? CustomDesc10 { get; set; }
    public string? CustomLabel10 { get; set; }
    public string? ResortId { get; set; }
    public string? AllKey { get; set; }
    public string? RateCodeId { get; set; }
    public string? RateCategoryKey { get; set; }
    public string? RateClassKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPdRateDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PD_RATE_DIM_VW");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ComplimentaryYn)
                .HasColumnName("COMPLIMENTARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CustomCol1)
                .HasColumnName("CUSTOM_COL_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol10)
                .HasColumnName("CUSTOM_COL_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol2)
                .HasColumnName("CUSTOM_COL_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol3)
                .HasColumnName("CUSTOM_COL_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol4)
                .HasColumnName("CUSTOM_COL_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol5)
                .HasColumnName("CUSTOM_COL_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol6)
                .HasColumnName("CUSTOM_COL_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol7)
                .HasColumnName("CUSTOM_COL_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol8)
                .HasColumnName("CUSTOM_COL_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol9)
                .HasColumnName("CUSTOM_COL_9")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc1)
                .HasColumnName("CUSTOM_DESC_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc10)
                .HasColumnName("CUSTOM_DESC_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc2)
                .HasColumnName("CUSTOM_DESC_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc3)
                .HasColumnName("CUSTOM_DESC_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc4)
                .HasColumnName("CUSTOM_DESC_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc5)
                .HasColumnName("CUSTOM_DESC_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc6)
                .HasColumnName("CUSTOM_DESC_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc7)
                .HasColumnName("CUSTOM_DESC_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc8)
                .HasColumnName("CUSTOM_DESC_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc9)
                .HasColumnName("CUSTOM_DESC_9")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel1)
                .HasColumnName("CUSTOM_LABEL_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel10)
                .HasColumnName("CUSTOM_LABEL_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel2)
                .HasColumnName("CUSTOM_LABEL_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel3)
                .HasColumnName("CUSTOM_LABEL_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel4)
                .HasColumnName("CUSTOM_LABEL_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel5)
                .HasColumnName("CUSTOM_LABEL_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel6)
                .HasColumnName("CUSTOM_LABEL_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel7)
                .HasColumnName("CUSTOM_LABEL_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel8)
                .HasColumnName("CUSTOM_LABEL_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel9)
                .HasColumnName("CUSTOM_LABEL_9")
                .IsUnicode(false);

            entity.Property(e => e.GdsAllowedYn)
                .HasColumnName("GDS_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HouseUseYn)
                .HasColumnName("HOUSE_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyProgramYn)
                .HasColumnName("LOYALTY_PROGRAM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NegotiatedYn)
                .HasColumnName("NEGOTIATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.RateCategoryDesc)
                .HasColumnName("RATE_CATEGORY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RateCategoryKey)
                .HasColumnName("RATE_CATEGORY_KEY")
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .IsUnicode(false);

            entity.Property(e => e.RateClassDesc)
                .HasColumnName("RATE_CLASS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RateClassKey)
                .HasColumnName("RATE_CLASS_KEY")
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RateCodeId)
                .HasColumnName("RATE_CODE_ID")
                .IsUnicode(false);

            entity.Property(e => e.RateDesc)
                .HasColumnName("RATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
