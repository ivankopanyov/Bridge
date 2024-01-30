namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsConvMarketingText
{
    public string? GdsHost { get; set; }
    public string? ResortChain { get; set; }
    public string? MarketingTextTypeOne { get; set; }
    public DateTime? BeginDate { get; set; }
    public string? MarketingTextTypeTwo { get; set; }
    public string? MarketingTextTypeThree { get; set; }
    public string? MarketingText { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ActivateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsConvMarketingText>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_CONV_MARKETING_TEXT");

            entity.HasIndex(e => new { e.GdsHost, e.ResortChain, e.MarketingTextTypeOne })
                .HasName("GDS_CONV_MARKETING_TEXT_IND1");

            entity.HasIndex(e => new { e.GdsHost, e.ResortChain, e.MarketingTextTypeOne, e.BeginDate, e.MarketingTextTypeTwo, e.MarketingTextTypeThree })
                .HasName("GDS_CONV_MARKETING_TEXT_UK")
                .IsUnique();

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketingText)
                .HasColumnName("MARKETING_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MarketingTextTypeOne)
                .IsRequired()
                .HasColumnName("MARKETING_TEXT_TYPE_ONE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MarketingTextTypeThree)
                .HasColumnName("MARKETING_TEXT_TYPE_THREE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MarketingTextTypeTwo)
                .HasColumnName("MARKETING_TEXT_TYPE_TWO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortChain)
                .IsRequired()
                .HasColumnName("RESORT_CHAIN")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
