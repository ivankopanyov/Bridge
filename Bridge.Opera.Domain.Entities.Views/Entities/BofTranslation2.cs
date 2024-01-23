namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofTranslation2
{
    public string Resort { get; set; }
    public string TransCode { get; set; }
    public string BofTransCode { get; set; }
    public decimal BofIntfCode { get; set; }
    public decimal BofTransId { get; set; }
    public string BofDataType { get; set; }
    public decimal? BofDataLength { get; set; }
    public string BofTransText { get; set; }
    public string InclDeptCodeYn { get; set; }
    public string InclSubgroupYn { get; set; }
    public string InclGroupYn { get; set; }
    public string InclMarketYn { get; set; }
    public string InclCountryYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofTranslation2>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_TRANSLATION");

            entity.Property(e => e.BofDataLength)
                .HasColumnName("BOF_DATA_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofDataType)
                .HasColumnName("BOF_DATA_TYPE")
                .HasMaxLength(20)
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

            entity.Property(e => e.InclCountryYn)
                .HasColumnName("INCL_COUNTRY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclDeptCodeYn)
                .HasColumnName("INCL_DEPT_CODE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclGroupYn)
                .HasColumnName("INCL_GROUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclMarketYn)
                .HasColumnName("INCL_MARKET_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InclSubgroupYn)
                .HasColumnName("INCL_SUBGROUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TransCode)
                .HasColumnName("TRANS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
