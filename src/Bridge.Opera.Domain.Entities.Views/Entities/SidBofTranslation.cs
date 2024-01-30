namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidBofTranslation
{
    public decimal? BofIntfCode { get; set; }
    public string? Resort { get; set; }
    public decimal? BofTransId { get; set; }
    public string? BofTransCode { get; set; }
    public string? BofTransText { get; set; }
    public string? BofDataType { get; set; }
    public decimal? BofDataLength { get; set; }
    public string? BofInclDeptCodeYn { get; set; }
    public string? BofInclSubgroupYn { get; set; }
    public string? BofInclGroupYn { get; set; }
    public string? BofInclMarketYn { get; set; }
    public string? BofInclCountryYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidBofTranslation>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_BOF$TRANSLATION");

            entity.Property(e => e.BofDataLength)
                .HasColumnName("BOF_DATA_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofDataType)
                .HasColumnName("BOF_DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofInclCountryYn)
                .HasColumnName("BOF_INCL_COUNTRY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BofInclDeptCodeYn)
                .HasColumnName("BOF_INCL_DEPT_CODE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BofInclGroupYn)
                .HasColumnName("BOF_INCL_GROUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BofInclMarketYn)
                .HasColumnName("BOF_INCL_MARKET_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BofInclSubgroupYn)
                .HasColumnName("BOF_INCL_SUBGROUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BofIntfCode)
                .HasColumnName("BOF_INTF_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofTransCode)
                .HasColumnName("BOF_TRANS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofTransId)
                .HasColumnName("BOF_TRANS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofTransText)
                .HasColumnName("BOF_TRANS_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
